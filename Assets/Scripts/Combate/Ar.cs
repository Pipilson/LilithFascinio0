using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ar : MonoBehaviour
{
    public Text texto;
    string desc;

    public void OnMouseOver()
    {
        desc = "Fascino de Ar - 20MP\nDiminuí o ataque de um inimigo em 1";
        texto.text = desc;
    }

    public void OnMouseExit()
    {
        desc = "";
        texto.text = desc;
    }
}