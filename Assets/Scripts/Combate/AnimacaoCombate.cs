using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoCombate : MonoBehaviour
{
    float spritecount = 0;
    public Sprite[] lilithCombate;
    public SpriteRenderer spriter;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        spritecount += Time.deltaTime * 6;

        if (spritecount >= 4)
        {
            spritecount = 0;
        }

        spriter.sprite = lilithCombate[(int)spritecount];
    }
}