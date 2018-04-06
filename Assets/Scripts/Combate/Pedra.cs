using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pedra : MonoBehaviour
{
    public Text texto;
    string desc;

    public void OnMouseOver()
    {
        desc = "Fascino de Terra - 10MP\nAumenta o seu ataque em 2";
        texto.text = desc;
    }

    public void OnMouseExit()
    {
        desc = "";
        texto.text = desc;
    }
}