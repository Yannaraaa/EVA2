using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorJuego : MonoBehaviour
{
    public TextMeshProUGUI textoVidas;
    public TextMeshProUGUI textoPuntaje;

    void Update()
    {
        ActualizarTextosEnTiempoReal();
    }

    void ActualizarTextosEnTiempoReal()
    {
        if (ScoreTracker.instance != null)
        {
            textoVidas.text = "Vidas: " + ScoreTracker.instance.getRemainingLifes().ToString();
            textoPuntaje.text = "Puntaje: " + ScoreTracker.instance.getScore().ToString();
        }
    }
}

