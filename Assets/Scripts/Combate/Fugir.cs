using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fugir : MonoBehaviour
{
    public Text texto;
    string desc;

    public void OnMouseOver()
    {
        desc = "Escapa da batalha";
        texto.text = desc;
    }

    public void OnMouseExit()
    {
        desc = "";
        texto.text = desc;
    }
}