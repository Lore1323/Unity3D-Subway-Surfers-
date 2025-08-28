using UnityEngine;

public class PlayerLocomotion : MonoBehaviour
{
    [Header("Movement")]
    public float velBase;
    public float velMax;
    public float aceleracion;
    public float alturaSalto;
    public float gravedad;
    public float laneWidth;
    public int laneActual; // 0=Izq, 1=Centro, 2=Der
    public float velocidadActual;

    public void CambiarCarril(int direccion)
    {
        // -1 izquierda, +1 derecha
    }

    public void Saltar()
    {
        // Activar animación y física de salto
    }
}
