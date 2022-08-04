using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveInput;
    private float speed = 10f;

    private float inputHorizontal = 0;
 

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
     
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

    }

    public void SetInputHoziontal(float valor)
    {

        inputHorizontal = valor;

    }

}
