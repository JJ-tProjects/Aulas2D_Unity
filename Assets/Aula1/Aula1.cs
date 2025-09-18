using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aula1 : MonoBehaviour
{
    public Text texto;
    public int Pontos = 0;

    public void Start()
    {
        texto.text = "Pontos: " + Pontos.ToString("N0");
    }
    public void Adicionar()
    {
        Pontos++;
        texto.text = "Pontos: " + Pontos.ToString("N0");
    }
    public void Subtrair()
    {
        Pontos--;
        texto.text = "Pontos: " + Pontos.ToString("N0");
    }
}
