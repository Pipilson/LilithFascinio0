using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atacar : MonoBehaviour
{
    public Text texto;
    string desc;

    public void OnMouseOver()
    {
        desc = "Ataque básico\n5 de dano em um inimigo";
        texto.text = desc;
    }

    public void OnMouseExit()
    {
        desc = "";
        texto.text = desc;
    }
}