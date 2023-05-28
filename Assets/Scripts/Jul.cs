using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jul : MonoBehaviour
{
    public bool notDragged = true;
    public float speed = 5f;
    public float speedMultiplier = 1f;
    private Vector2 movement;
    private Rigidbody2D playerRB;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!notDragged)
        {
            movement.y = 0;
            movement.x = 1;
            playerRB.velocity = movement * speed * speedMultiplier;
        }
    }
}
