using UnityEngine;

public class CurrencyManager : MonoBehaviour
{
    public int monedasCorrida;
    public int monedasTotales;

    public void Sumar(int valor)
    {
        monedasCorrida += valor;
    }

    public void ConsolidarRun()
    {
        monedasTotales += monedasCorrida;
        monedasCorrida = 0;
    }
}
