using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GameState { Menu, Countdown, Playing, Paused, GameOver }
    public GameState currentState;

    [Header("UI")]
    public GameObject panelGameOver;

    [Header("References")]
    public SpawnerDirector spawnerDirector;
    public ScoreManager scoreManager;
    public CurrencyManager currencyManager;
    public Player player;

    [Header("Run Data")]
    public RunSession currentSession;

    void Awake()
    {
        Instance = this;
    }

    public void StartRun()
    {
        // Cambiar a estado Playing y reiniciar sistemas
    }

    public void EndRun()
    {
        currentState = GameState.GameOver;
        Time.timeScale = 0f; // Pausa el juego
        panelGameOver.SetActive(true);
    }

    public void RestartGame()
    {
        Time.timeScale = 1f; // Reactivar tiempo
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SetState(GameState newState)
    {
        currentState = newState;
    }
}

