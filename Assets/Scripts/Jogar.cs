using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogar : MonoBehaviour
{
    public void ReiniciarJogo()
    {
        SceneManager.LoadScene("Overworld");
    }

    public void FecharJogo()
    {
        Application.Quit();
    }
}