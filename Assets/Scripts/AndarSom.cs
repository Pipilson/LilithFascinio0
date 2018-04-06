using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndarSom : MonoBehaviour
{
    public AudioSource passos;

    void Start()
    {
        passos.volume = 0;
        passos.pitch = 1.5f;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            passos.volume = 1;

            if (Input.GetKey(KeyCode.LeftShift))
            {
                passos.pitch = 2.5f;
            }

            else
            {
                passos.pitch = 1.5f;
            }
        }

        else
        {
            passos.volume = 0;
        }
    }
}