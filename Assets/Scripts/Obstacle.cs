using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Type type;
    [SerializeField] private GameObject newObstacle;
    public Sprite newSprite;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Type julType = other.gameObject.GetComponent<Jul>().GetJulType();
        switch (julType)
        {
            case Type.Bri:
                switch (type)
                {
                    case Type.Bri:
                        gameObject.GetComponent<Collider2D>().isTrigger = false;
                        break;

                    case Type.Chan:
                        //Pass Through
                        break;

                    case Type.Can:
                        gameObject.GetComponent<Collider2D>().isTrigger = false;
                        break;

                    case Type.Oli:
                        var newObstacle = Instantiate(this.newObstacle, this.transform.position, Quaternion.identity);
                        newObstacle.GetComponent<SpriteRenderer>().sprite = newSprite;
                        Destroy(other.gameObject);
                        Destroy(this.gameObject);
                        break;
                }
                break;

            case Type.Chan:
                switch (type)
                {
                    case Type.Bri:
                        var newObstacle = Instantiate(this.newObstacle, this.transform.position, Quaternion.identity);
                        newObstacle.GetComponent<SpriteRenderer>().sprite = newSprite;
                        Destroy(other.gameObject);
                        Destroy(this.gameObject);
                        break;

                    case Type.Chan:
                        gameObject.GetComponent<Collider2D>().isTrigger = false;
                        break;

                    case Type.Can:
                        //Pass Through
                        break;

                    case Type.Oli:
                        gameObject.GetComponent<Collider2D>().isTrigger = false;
                        break;
                }
                break;

            case Type.Can:
                switch (type)
                {
                    case Type.Bri:
                        gameObject.GetComponent<Collider2D>().isTrigger = false;
                        break;

                    case Type.Chan:
                        var newObstacle = Instantiate(this.newObstacle, this.transform.position, Quaternion.identity);
                        newObstacle.GetComponent<SpriteRenderer>().sprite = newSprite;
                        Destroy(other.gameObject);
                        Destroy(this.gameObject);
                        break;

                    case Type.Can:
                        gameObject.GetComponent<Collider2D>().isTrigger = false;
                        break;

                    case Type.Oli:
                        //Pass Through
                        break;

                }
                break;

            case Type.Oli:
                switch (type)
                {
                    case Type.Bri:
                        //Pass Through
                        break;

                    case Type.Chan:
                        gameObject.GetComponent<Collider2D>().isTrigger = false;
                        break;

                    case Type.Can:
                        var newObstacle = Instantiate(this.newObstacle, this.transform.position, Quaternion.identity);
                        newObstacle.GetComponent<SpriteRenderer>().sprite = newSprite;
                        Destroy(other.gameObject);
                        Destroy(this.gameObject);
                        break;


                    case Type.Oli:
                        gameObject.GetComponent<Collider2D>().isTrigger = false;
                        break;

                }
                break;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        gameObject.GetComponent<Collider2D>().isTrigger = true;
    }

}