using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Type type;

    private void OnCollisionEnter2D(Collision2D other) {
        Type julType = other.gameObject.GetComponent<Jul>().GetType();
        switch (julType)
        {
            

        }
    }
}
