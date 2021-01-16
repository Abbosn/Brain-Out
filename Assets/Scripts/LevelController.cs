using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{   
    public LevelData[] levelData;
    private int levelNumber;
    private GameData gameData = GameData.GameDataInitialize();
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        SceneManager.LoadScene("Menu");
        if(gameData.lights == 0)
        {
            gameData.lights = 4;
        }
    }

    public LevelData GetCurrentLevelData()
    {
        return levelData[levelNumber];
    }
}
