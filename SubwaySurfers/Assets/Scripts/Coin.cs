using UnityEngine;

public class Coin : MonoBehaviour, ISpawnable, IPickup
{
    public int valor;

    public void Recoger(Player player)
    {
        // player.pickup.OnRecogerMoneda(valor)
    }

    public void Activar(Vector3 pos, object parametros = null)
    {
        // Activar moneda
    }

    public void Desactivar()
    {
        // Desactivar moneda
    }
}
