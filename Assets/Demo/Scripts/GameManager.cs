using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject gameOverUI;
    public GameObject player;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        gameOverUI.SetActive(false);
    }

    public void OnPlayerDied()
    {
        ShowGameOver();
    }


    void ShowGameOver()
    {
        gameOverUI.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = false;
        Time.timeScale = 0f;
    }
}
