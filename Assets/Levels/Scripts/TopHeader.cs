using UnityEngine;
using UnityEngine.SceneManagement;

public class TopHeader : MonoBehaviour
{
    public void BackButton()
    {
        SceneManager.LoadScene("LevelSelector");
    }
}
