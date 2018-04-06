using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoverPlayer : MonoBehaviour
{
    public GameObject cogumelo, dark;
    public AudioSource cogumeloSom;
    float spritecount = 0;
    public Sprite[] lilith;
    public SpriteRenderer spriter, darkSpriter;
    bool cogMove = true;

    // Use this for initialization
    void Start()
    {
        cogumelo = GameObject.FindGameObjectWithTag("Cogumelo");
        dark = GameObject.FindGameObjectWithTag("Enemy");
        cogumeloSom.volume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Mover();
        AnimarIdle();
        Puzzle();

        if (Input.GetKey(KeyCode.Q))
        {
            SceneManager.LoadScene("Battle");
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            cogumeloSom.pitch = 2;
        }

        else
        {
            cogumeloSom.pitch = 1;
        }

        if (!cogMove)
        {
            cogumelo.transform.position = new Vector3(2.71f, 1.57f, 0);
            cogumeloSom.volume = 0;
        }
    }

    private void Puzzle()
    {
        if (cogumelo.transform.position.x >= 2.71f)
        {
            cogMove = false;
            dark.transform.position = new Vector3(5.93f, -1.38f, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        cogumeloSom.volume = 1;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        cogumeloSom.volume = 0;
    }

    public void Mover()
    {
        float mov = 2;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            mov = 4;
        }

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y <= 3.2f)
        {
            transform.position += new Vector3(0, mov, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y >= -3.9f)
        {
            transform.position += new Vector3(0, -mov, 0) * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -10)
        {
            transform.position += new Vector3(-mov, 0, 0) * Time.deltaTime;
            transform.rotation = new Quaternion(0, -90, 0, 0);

        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 9.9f)
        {
            transform.position += new Vector3(mov, 0, 0) * Time.deltaTime;
            transform.rotation = new Quaternion(0, 0, 0, 0);
        }
    }

    public void AnimarIdle()
    {
        spritecount += Time.deltaTime * 3;

        if (spritecount >= lilith.Length)
        {
            spritecount = 0;
        }

        if (!Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow) && !Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.DownArrow))
        {
            spriter.sprite = lilith[(int)spritecount];
        }
    }
}