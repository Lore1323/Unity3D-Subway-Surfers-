using UnityEngine;

public interface ISpawnable
{
    void Activar(Vector3 pos, object parametros = null);
    void Desactivar();
}
