using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public static Circle _instance;

    Rigidbody2D rb;

    public float jumpSpeed;

    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }


    public void Jump()
    {
        rb.velocity = Vector2.up * jumpSpeed;
    }

}
