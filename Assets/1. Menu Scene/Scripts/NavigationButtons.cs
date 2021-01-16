using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NavigationButtons : MonoBehaviour
{
    [SerializeField] private Text lights;
    private GameData gameData = GameData.GameDataInitialize();
    private void Start()
    {
        lights.text = gameData.lights.ToString();
    }
    public void ShopSceneButton()
    {
        SceneManager.LoadScene("Shop");
    }
    public void SettingsButton()
    {
        SceneManager.LoadScene("Settings");
    }
    public void DiaryButton()
    {
        SceneManager.LoadScene("DiaryPoint");
    }
    public void StartGame()
    {
        SceneManager.LoadScene("LevelSelector");
    }
}
