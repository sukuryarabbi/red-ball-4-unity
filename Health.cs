using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{
    public int health = 5;

    public Image[] hearts;

    public Sprite fullHeart;

    public Sprite emptyHeart;

    public PlayerScriptsd playerscript;

    

    void Start()
    {
        playerscript = GetComponent<PlayerScriptsd>();

        playerscript.RedBallHealth = health;


    }


    void Update()
    {
        foreach(Image img in hearts)
        {
            img.sprite = emptyHeart;
        }

        for(int i = 0; i < health; i++)
        {
            hearts[i].sprite = fullHeart;
        }
    }

   
}
