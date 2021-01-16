using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StaticChoice : MonoBehaviour
{
    public Button[] answers;
    public GameObject xPrefab;
    public GameObject yesPrefab;
    public GameObject winDisplay;
    private GameObject newInstance;

    public Text sceneNumber;

    private GameData gameData = GameData.GameDataInitialize();
    private LevelController levelController;
    private LevelData[] levelData;

    private void Start()
    {
        levelController = FindObjectOfType<LevelController>();
        levelData = levelController.levelData;
    
    }
    public void TrueAnswer(int buttonPressed)
    {
        
        if (buttonPressed == 0)
        {
            Instantiate(yesPrefab, answers[0].transform);

            if (!levelData[int.Parse(sceneNumber.text)].isCompleted)
            {
                levelData[gameData.countOfCompletedLevels].isCompleted = true;
                gameData.countOfCompletedLevels++;
            }
            Debug.Log(gameData.countOfCompletedLevels);
            StartCoroutine(WinLevelCo());
        }
        else
        {
            newInstance = Instantiate(xPrefab, answers[buttonPressed].transform);
            Destroy(newInstance, 0.6f);
        }        
    }
    
    IEnumerator WinLevelCo()
    {   
        yield return new WaitForSeconds(0.6f);
        winDisplay.SetActive(true);
    }
    
}
