using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aula2 : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Transform transform;
    public Text textoPontos;
    public int Pontos = 0;
    public int X = 0;
    public int Y = 0;

    public void MoverParaCima()
    {
        Y++;

        if (Y > 5)
            Y = -5;

        AtualizarPosicao();
    }
    public void MoverParaBaixo()
    {
        Y--;

        if (Y < -5)
            Y = 5;

        AtualizarPosicao();
    }
    public void MoverParaEsquerda()
    {
        X--;
        if (X < -9)
            X = 9;
            
        sprite.flipX = true;
        AtualizarPosicao();
    }
    public void MoverParaDireita()
    {
        X++;

        if (X > 9)
            X = -9;
        sprite.flipX = false;
        AtualizarPosicao();
    }

    public void AtualizarPosicao()
    {
        transform.position = new Vector3(X, Y, 0);
    }
}
