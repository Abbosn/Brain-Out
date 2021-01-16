using UnityEngine;
using UnityEngine.SceneManagement;

public class WinDisplay : MonoBehaviour
{
    public void NextRoundButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

