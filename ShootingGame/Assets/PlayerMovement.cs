using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movSpeed = 5f;

    void Update()
    {
        // Daca apas LeftArrow, merg spre stanga
        // Daca apas RightArrow, merg spre dreapta
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.position += Vector2.left * movSpeed * Time.deltaTime;
            // Vector3.left = (-1, 0, 0)
            // directie * viteza * deltaTime
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.position += Vector2.right * movSpeed * Time.deltaTime;
            // Vector3.right = (1, 0, 0)
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.position += Vector2.up * movSpeed * Time.deltaTime;
            // Vector3.up = (0, 1, 0)
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.position += Vector2.down * movSpeed * Time.deltaTime;
            // Vector3.down = (0, -1, 0)
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.name);
    }
}
