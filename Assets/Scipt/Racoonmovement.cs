using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Racoonmovement : MonoBehaviour
{
    private Vector2 moveDirection;
    public Transform player;
    public float escapeSpeed = 5.0f;
    private Rigidbody2D rb;
    [SerializeField] private Animator anim;


    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        float speedX = rb.velocity.x;

        // Calcula el valor para "RunDirection" basado en la velocidad en el eje X.
        float runDirection = Mathf.Sign(speedX);



        Vector2 escapeDirection = transform.position - player.position;
        escapeDirection.Normalize();

        // Aplica velocidad al enemigo (Rigidbody2D)
        GetComponent<Rigidbody2D>().velocity = escapeDirection * escapeSpeed;
    }

   

    


}
