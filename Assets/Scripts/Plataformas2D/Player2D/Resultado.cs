using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resultado : MonoBehaviour
{
    [SerializeField] private ControladorPintadas pintadaScript;
    public void Victoria()
    {
        SelectorFinales.aņadirALaLista(true);
        pintadaScript.activaPintada(4);
        pintadaScript.activaPintada(6);
    }

    public void Derrota()
    {
        SelectorFinales.aņadirALaLista(false);
    }
}
