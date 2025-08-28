using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [Header("Vidas")]
    public int vidasMax;
    public int vidasActuales;
    public bool invulnerable;
    public float tiempoInvulnerable;

    private void Start()
    {
        vidasMax = vidasActuales;
    }

    public void OnGolpe()
    {
        vidasActuales --;
        Debug.Log("Golpe recibido. Vidas restantes: ");
        if (vidasActuales<=0)
            GetComponent<Player>().Die();
    }
}
