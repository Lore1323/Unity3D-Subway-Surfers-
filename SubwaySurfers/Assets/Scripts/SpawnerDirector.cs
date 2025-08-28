using UnityEngine;
using System.Collections.Generic;

public class SpawnerDirector : MonoBehaviour
{
    public float distanciaParaSpawn;
    public List<TrackSegment> segmentosActivos;
    public float nivelDificultad;

    public void SpawnSiguienteSegmento()
    {
        // Instanciar o reciclar un segmento
    }

    public void ReciclarSegmento(TrackSegment segment)
    {
        // Devolver al pool
    }

    public void EscalarDificultad(float distancia)
    {
        // Ajustar nivelDificultad según distancia
    }
}
