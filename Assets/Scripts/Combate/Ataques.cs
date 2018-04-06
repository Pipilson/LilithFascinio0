using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ataques : MonoBehaviour
{
    public AudioSource fuga;
    public Button fogo, terra, agua, ar, ataque, fugir;
    public GameObject lilithIdle, lilithAdaga, lilithFlauta, birdo;
    float timer, timer2;
    bool trava = true, fugindo = false;

    // Use this for initialization
    void Start()
    {
        lilithIdle = GameObject.FindGameObjectWithTag("Player");
        lilithAdaga = GameObject.FindGameObjectWithTag("Adaga");
        lilithFlauta = GameObject.FindGameObjectWithTag("Flauta");
        birdo = GameObject.FindGameObjectWithTag("Enemy");
        timer = 0;
        timer2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!trava)
        {
            timer++;
        }

        if (fugindo)
        {
            timer2++;
        }

        if (timer == 0 && timer2 == 0)
        {
           ataque.interactable = true;
           fugir.interactable = true;
        }

        else
        {
            fogo.interactable = false;
            terra.interactable = false;
            agua.interactable = false;
            ar.interactable = false;
            ataque.interactable = false;
            fugir.interactable = false;
        }

        if (timer >= 50)
        {
            lilithIdle.transform.position = new Vector3(-4, -0.2f, 0);
            lilithAdaga.transform.position = new Vector3(0, -50, 0);
            lilithFlauta.transform.position = new Vector3(0, -50, 0);
            birdo.transform.position += new Vector3(1, 0, 0);
            timer = 0;
            trava = true;
        }

        if (timer2 >= 50)
        {
            SceneManager.LoadScene("OverworldFake");
        }
    }

    public void Ataque()
    {
        lilithIdle.transform.position = new Vector3(0, -50, 0);
        lilithAdaga.transform.position = new Vector3(-4, -0.2f, 0);
        lilithFlauta.transform.position = new Vector3(0, -50, 0);
        birdo.transform.position += new Vector3(-1, 0, 0);
        trava = false;
    }

    public void Magica()
    {
        lilithIdle.transform.position = new Vector3(0, -50, 0);
        lilithFlauta.transform.position = new Vector3(-4, -0.2f, 0);
        lilithAdaga.transform.position = new Vector3(0, -50, 0);
        birdo.transform.position += new Vector3(-1, 0, 0);
        trava = false;
    }

    public void Fugir()
    {
        fuga.Play();
        lilithIdle.transform.position = new Vector3(-4, -0.2f, 0);
        lilithAdaga.transform.position = new Vector3(0, -50, 0);
        lilithFlauta.transform.position = new Vector3(0, -50, 0);
        lilithIdle.transform.rotation = new Quaternion(0, -90, 0, 0);
        fugindo = true;
    }
}