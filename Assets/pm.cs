using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pm : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    float score;
    public TextAlignment scoretxt;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

   
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="point")
        {
            score++;
        }
        if (collision.gameObject.tag=="pipa")
        {
            Destroy(gameObject);
        }
    }
}
