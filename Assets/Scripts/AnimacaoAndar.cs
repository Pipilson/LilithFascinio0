using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacaoAndar : MonoBehaviour
{
    float spritecount = 0;
    public Sprite[] lilith;
    public SpriteRenderer spriter;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        spritecount += Time.deltaTime * 6;

        if (spritecount >= lilith.Length)
        {
            spritecount = 0;
        }

        if (!Input.GetKey(KeyCode.LeftShift))
        {
            spriter.sprite = lilith[(int)spritecount];
        }
    }
}