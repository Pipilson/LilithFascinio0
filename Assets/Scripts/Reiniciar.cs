﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reiniciar : MonoBehaviour
{
    public void ReiniciarJogo()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void FecharJogo()
    {
        Application.Quit();
    }
}