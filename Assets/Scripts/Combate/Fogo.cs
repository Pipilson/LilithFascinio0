using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fogo : MonoBehaviour
{
    public Text texto;
    string desc;

    public void OnMouseOver()
    {
        desc = "Fascino de Fogo - 20MP\n15 de dano em um inimigo";
        texto.text = desc;
    }

    public void OnMouseExit()
    {
        desc = "";
        texto.text = desc;
    }
}