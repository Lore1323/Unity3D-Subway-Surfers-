using System;
using UnityEngine;

public class Tren : ObstaculoBase
{
    public float velRelativa;
    public float longitudTren;

    public void Mover()
    {
        // Movimiento del tren
    }

    public override void AplicaGolpe(Player player)
    {
        player.collision.OnGolpe();
    }

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            AplicaGolpe(player);
        }
    }
}
