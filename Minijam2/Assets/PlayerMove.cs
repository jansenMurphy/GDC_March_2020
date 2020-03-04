using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Vector3 move = Vector3.zero;
    Rigidbody2D rb2d;
    public float idealHorzSpeed = 1f, horzAccel = 1f, jumpForce=1f, gravityForce = 1f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f);
        rb2d.AddForce (new Vector3(Mathf.Lerp(rb2d.velocity.x, horzAccel, move.x)*Mathf.Sign(move.x), 0f, 0f)*Time.deltaTime);
        Debug.Log(move.x);

    }
}
