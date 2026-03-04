using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject gameOverUI;
    public GameObject player;
    private int enemyCount;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        enemyCount = FindObjectsOfType<EnemyHealth>().Length;
        gameOverUI.SetActive(false);
    }

    public void OnPlayerDied()
    {
        ShowGameOver();
    }

    public void OnEnemyDied()
    {
        enemyCount--;

        if (enemyCount <= 0)
        {
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        gameOverUI.SetActive(true);
        player.GetComponent<PlayerMovement>().enabled = false;
        Time.timeScale = 0f;
    }
}
