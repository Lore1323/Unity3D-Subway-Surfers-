using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GameState { Menu, Countdown, Playing, Paused, GameOver }
    public GameState currentState;

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
        // Mostrar pantalla GameOver
    }

    public void RestartGame()
    {
        // Reiniciar escena o resetear datos
    }

    public void SetState(GameState newState)
    {
        currentState = newState;
    }
}

