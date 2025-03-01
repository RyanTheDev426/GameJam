using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int health;
    public int numHearts;
    public Image[] hearts;

    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        PlayerHP playerHealth = FindObjectOfType<PlayerHP>();
        health = playerHealth.HP;
        if(health > numHearts)
        {
            health = numHearts;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }
            if(i < numHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
