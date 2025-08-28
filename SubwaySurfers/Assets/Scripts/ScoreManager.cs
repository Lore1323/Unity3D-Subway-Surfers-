using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public float distancia;
    public float multiplicadorDistancia;

    public void AcumularDistancia(float delta)
    {
        // distancia += delta * multiplicadorDistancia
    }

    public void ResetScore()
    {
        distancia = 0;
    }
}
