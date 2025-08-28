using UnityEngine;

public abstract class ObstaculoBase : MonoBehaviour, ISpawnable, IDetectableChoque
{
    public int lane;
    public float altura;
    public int ocupaLanes; // Bitmask

    public abstract void AplicaGolpe(Player player);

    public void Activar(Vector3 pos, object parametros = null)
    {
        // Activar obstáculo
    }

    public void Desactivar()
    {
        // Desactivar obstáculo
    }
}
