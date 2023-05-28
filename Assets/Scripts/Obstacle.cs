using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Type type;
    public GameObject newObstacle;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Type julType = other.gameObject.GetComponent<Jul>().GetJulType();
        switch (julType)
        {
            case Type.Bri:
                switch (type)
                {
                    case Type.Chan:
                        Physics2D.IgnoreCollision(other.gameObject.GetComponent<Collider2D>(), this.GetComponent<Collider2D>());
                        Debug.Log("Ignoring collision");
                        break;
                    case Type.Oli:
                        Instantiate(this.newObstacle, this.transform.position, Quaternion.identity);
                        Destroy(other.gameObject);
                        Destroy(this.gameObject);
                        break;
                }
                break;
        }
    }
}
