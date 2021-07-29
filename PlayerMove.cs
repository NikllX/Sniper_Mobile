using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public Joystick joystick;
    public Rigidbody2D rb;
    Vector2 move;
    public Transform Player;
    private float rotationZ;
    private Vector2 moveInput;
    private Vector2 moveVelociry;
    private float MoveInput;

    void Update()
    {
        MoveInput = joystick.Horizontal;
        rb.velocity = new Vector2( MoveInput * speed,rb.velocity.y); 
    }

}
