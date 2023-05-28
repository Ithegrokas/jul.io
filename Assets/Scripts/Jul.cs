using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Type {Bri, Chan, Can, Oli}
public class Jul : MonoBehaviour
{
    private bool clicked = false;
    [SerializeField] private Type type;
    [SerializeField][Range(0,50)] private float speed = 5f;
    [SerializeField][Range(0,10)] private float speedMultiplier = 1f;
    private Vector2 movement = Vector2.zero;
    private Rigidbody2D playerRB;

    void Update ()
    {
        if (clicked)
        {
            playerRB.velocity = speed * speedMultiplier * movement;
        }
    }

    public void Clicked() 
    {
        //Initializing Variables and Components
        clicked = true;
        playerRB = gameObject.AddComponent<Rigidbody2D>();
        playerRB.freezeRotation = true;
        playerRB.angularDrag = 0f;
        movement.x = 1f;
    }

    public Type GetJulType()
    {
        return type;
    }

    public bool IsClicked() 
    {
        return clicked;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.CompareTag("Terrain"))
        {
            movement.x = 1.5f;
            playerRB.velocity = speed * speedMultiplier * movement;
            playerRB.gravityScale = 0f;
        }
    }

    private void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.CompareTag("Terrain"))
        {
            movement.x = 0.5f;
            playerRB.velocity = speed * speedMultiplier * movement;
            playerRB.gravityScale = 20f;
        }
    }
}
