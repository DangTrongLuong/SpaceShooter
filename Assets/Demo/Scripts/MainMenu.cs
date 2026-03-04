using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        SceneManager.LoadScene("Battle");
    }
    public void ExitButtonClicked()
    {
        SceneManager.LoadScene("Main Menu");
    }
}