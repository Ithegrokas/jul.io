using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop : MonoBehaviour
{
    private Vector3 mousePosition;

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

            //Check if target is in fact a Jul and if Jul hasn't been clicked
            if (targetObject?.tag == "Jul" && !targetObject.GetComponent<Jul>().IsClicked())
            {
                targetObject.transform.position = gameObject.transform.position;
                targetObject.GetComponent<Jul>().Clicked();
                targetObject = null;
            }
        }
    }

}
