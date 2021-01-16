using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class QuestionWithInput : MonoBehaviour
{
    private int counterNumber = 0;
    public Text counter;
    public Text sceneNumber;
    private GameObject newInstance;
    public GameObject winDisplay;
    public GameObject xPrefab;
    public GameObject yesPrefab;
    public GameObject questionImage;

    private GameData gameData = GameData.GameDataInitialize();
    private LevelController levelController;
    private LevelData[] levelData;
    

    private void Start()
    {
        levelController = FindObjectOfType<LevelController>();
        levelData = levelController.levelData;
    }
    public void Decrement()
    {
        counterNumber++;
        counter.text = counterNumber.ToString();
    }
    public void Increment()
    {
        counterNumber--;
        if(counterNumber < 0)
        {
            counterNumber = 0;
        }
        counter.text = counterNumber.ToString();
    }
    public void ClearCounter()
    {
        counterNumber = 0;
        counter.text = counterNumber.ToString();
    }
    public void OkWin()
    {
        if(counterNumber == 9)
        {   
            StartCoroutine(WinLevelCo());
            Instantiate(yesPrefab, questionImage.transform);
            if (!levelData[int.Parse(sceneNumber.text)].isCompleted)
            {
                levelData[gameData.countOfCompletedLevels].isCompleted = true;
                gameData.countOfCompletedLevels++;
            }
        }
        else
        {
            newInstance = Instantiate(xPrefab, questionImage.transform);
            Destroy(newInstance, 0.6f);
        }
    }
    IEnumerator WinLevelCo()
    {
        yield return new WaitForSeconds(0.6f);
        winDisplay.SetActive(true);
    }
}
