using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector2 move = Vector3.zero;
    Rigidbody2D rb2d;
    public float idealHorzSpeed = 1f, horzAccel = 1f, jumpForce=1f, gravityForce = 1f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        rb2d.MovePosition(move*Time.deltaTime + rb2d.position);

    }
}
