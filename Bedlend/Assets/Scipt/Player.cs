using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class Player : MonoBehaviour
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

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) /*&& IsJump*/)
        {
            Debug.Log("Enter");
            rb.AddForce( Vector2.up *  force, ForceMode2D.Impulse);
            //StartCoroutine(ClicSpaseTimer());

            
        }
        moveVector.x = Input.GetAxis("Horizontal") * speed;
        moveVector.y = rb.velocity.y;
        Debug.Log(moveVector);

        rb.velocity  = ( moveVector *  Time.deltaTime);

    }
    IEnumerator ClicSpaseTimer()
    {
        IsJump = false;
        Debug.Log("Fals");
        yield return new WaitForSeconds(1);
        IsJump = true;
        Debug.Log("tru");

    }

    
}
