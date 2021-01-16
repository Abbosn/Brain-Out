using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public Button[] levelButtons;
    private GameData gameData = GameData.GameDataInitialize();
    void Start()
    {
        
        for(int i = 0; i < levelButtons.Length; i++)
        {   
            if(i + 1 > gameData.countOfCompletedLevels+1)
            {
                levelButtons[i].interactable = false;
            }
                
        }
    }
    public void Select(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}
 