using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CombateMenu : MonoBehaviour
{
    public GameObject lilith, flauta;
    public Button fogo, terra, agua, ar;
    public Text hpPlayer, hpEnemy, mpPlayer, mpEnemy;
    public AudioSource atk, fgo, aga, ter, ven;
    int x = 0, y = 0, hpP = 100, hpE = 100, mpP = 100, mpE = 100;

    void Start()
    {
        lilith = GameObject.FindGameObjectWithTag("Player");
        flauta = GameObject.FindGameObjectWithTag("Flauta");
    }

    public void Atacar()
    {
        atk.Play();
        hpE -= 5 + x;
        FimTurno();
    }

    public void Fogo()
    {
        fgo.Play();
        mpP -= 20;
        hpE -= 15;
        flauta.GetComponent<Renderer>().material.color = Color.red;
        FimTurno();
    }

    public void Pedra()
    {
        ter.Play();
        mpP -= 10;
        x += 2;
        flauta.GetComponent<Renderer>().material.color = Color.black;
        FimTurno();
    }

    public void Agua()
    {
        aga.Play();
        mpP -= 20;
        hpP += 15;
        flauta.GetComponent<Renderer>().material.color = Color.blue;
        FimTurno();
    }

    public void Ar()
    {
        ven.Play();
        mpP -= 20;
        y -= 1;
        flauta.GetComponent<Renderer>().material.color = Color.green;
        FimTurno();
    }

    void FimTurno()
    {
        System.Random rnd = new System.Random();
        int acao = rnd.Next(0, 11);

        if (acao <= 5)
        {
            hpP -= 5 + y;
        }

        if (acao >= 6 && acao <= 8)
        {
            if (mpE >= 10)
            {
                mpE -= 10;
                y += 2;
            }
        }

        if (acao >= 9 && mpE >= 20)
        {
            mpE -= 20;
            hpP -= 15;
        }

        if (acao >= 9 && mpE < 20)
        {
            rnd.Next(0, 9);
        }
    }

    void Update()
    {
        if (hpP > 100)
        {
            hpP = 100;
        }

        if (y <= 0)
        {
            y = 1;
        }

        if (hpP <= 0)
        {
            hpP = 0;
            SceneManager.LoadScene("Lose");
        }

        if (hpE <= 0)
        {
            hpE = 0;
            SceneManager.LoadScene("Win");
        }

        hpPlayer.text = "HP: " + hpP;
        mpPlayer.text = "MP: " + mpP;
        hpEnemy.text = "HP: " + hpE;
        mpEnemy.text = "MP: " + mpE;

        if (mpP < 20)
        {
            fogo.interactable = false;
            ar.interactable = false;
            agua.interactable = false;
        }

        if (mpP >= 20)
        {
            fogo.interactable = true;
            ar.interactable = true;
            agua.interactable = true;
        }

        if (mpP < 10)
        {
            terra.interactable = false;
        }

        if (mpP >= 10)
        {
            terra.interactable = true;
        }

        if (hpP >= 100)
        {
            agua.interactable = false;
        }

        if (hpP < 100 && mpP >= 20)
        {
            agua.interactable = true;
        }
    }
}