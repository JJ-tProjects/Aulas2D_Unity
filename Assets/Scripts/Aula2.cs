using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aula2 : MonoBehaviour
{
    public SpriteRenderer sprite;
    public Transform transform;

    public Text textoPontos;
    public Text textoVida;
    
    public int Pontos = 0;
    public int Vida = 100;
    
    public int X = 0;
    public int Y = 0;

    public GameObject Item;
    public GameObject Inimigo;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Inimigo")
        {
            Vida -= 10;
            Destroy(collision.gameObject);
            GerarInimigo();
        }
        
        if(collision.gameObject.tag == "Item")
        {
            Pontos++;
            Destroy(collision.gameObject);
            GerarItem();
        }

        AtualizarPontos();
        AtualizarVida();
    }
    private void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            GerarItem();

            for (int j = 0; j < 4; j++)
                GerarInimigo();
        }
    }
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
    public void AtualizarPontos()
    {
        textoPontos.text = "Pontos: " + Pontos;
    }
    public void AtualizarVida()
    {
        textoVida.text = "Vida: " + Vida;
    }

    public void GerarInimigo()
    {
        int x = Random.Range(9, -9);
        int y = Random.Range(5, -5);

        if (x == X)
            x++;

        if (y == Y) 
            y++;

        Vector3 posicaoVisivel = new Vector3(x, y, 0);
        GameObject.Instantiate(Inimigo, posicaoVisivel, Quaternion.identity);
    }
    public void GerarItem()
    {
        int x = Random.Range(9, -9);
        int y = Random.Range(5, -5);

        if (x == X)
            x++;

        if (y == Y)
            y++;

        Vector3 posicaoVisivel = new Vector3(x, y, 0);
        GameObject.Instantiate(Item, posicaoVisivel, Quaternion.identity);
    }
}
