using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerMovement : MonoBehaviour
{
    private Vector2 moveDirection;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;
    void Update()
    {
      Movement();
      Animate();
    }

    public void Movement()
    {
        float movX = Input.GetAxisRaw("Horizontal");
        float movY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(movX, movY).normalized;

        rb.velocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);
    }
    
    public void Animate()
    {
        anim.SetFloat("movX", moveDirection.x);
        anim.SetFloat("movY", moveDirection.y);
    }

}
