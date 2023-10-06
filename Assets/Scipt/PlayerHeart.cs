using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHeart : MonoBehaviour
{
    [SerializeField] private RawImage[] hearts;
    private int heartCount;
    void Start()
    {
        heartCount = 3;
    }

   
    void Update()
    {
        switch (heartCount)
        {
            case 0:
                hearts[0].GetComponent<RawImage>().enabled = false;
                break;

            case 1:
                hearts[1].GetComponent<RawImage>().enabled = false;
                break;

            case 2:
                hearts[2].GetComponent<RawImage>().enabled = false;
                break;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            heartCount--;
        }
    }
}
