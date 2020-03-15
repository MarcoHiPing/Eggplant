using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovementTest : MonoBehaviour
{
    public Transform player1;

    public Transform player2;

    public float moveSpeed;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            player1.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            player1.position += Vector3.left * moveSpeed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.S))
        {
            player1.position += Vector3.back * moveSpeed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.D))
        {
            player1.position += Vector3.right * moveSpeed * Time.deltaTime;

        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            player2.position += Vector3.forward * moveSpeed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            player2.position += Vector3.left * moveSpeed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            player2.position += Vector3.back * moveSpeed * Time.deltaTime;

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player2.position += Vector3.right * moveSpeed * Time.deltaTime;

        }
    }
}
