using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jhamp : MonoBehaviour
{
    private Rigidbody2D rb;
    public float force = 14.0f;
    public float speed = 0.5f;
    private Vector2 moveVector;
    private bool IsJump = true;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsJump)
        {
            Debug.Log("Enter");
            rb.AddForce(new Vector2(0, force), ForceMode2D.Impulse);
            


        }
       

    }
}
