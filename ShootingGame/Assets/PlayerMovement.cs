using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movSpeed = 5f;

    void Update()
    {
        // Daca apas LeftArrow, merg spre stanga
        // Daca apas RightArrow, merg spre dreapta
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * movSpeed * Time.deltaTime;
            // Vector3.left = (-1, 0, 0)
            // directie * viteza * deltaTime
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * movSpeed * Time.deltaTime;
            // Vector3.right = (1, 0, 0)
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * movSpeed * Time.deltaTime;
            // Vector3.up = (0, 1, 0)
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * movSpeed * Time.deltaTime;
            // Vector3.down = (0, -1, 0)
        }
    }
}
