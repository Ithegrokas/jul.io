using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private int currentScene = 0;
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D other)
    {
        currentScene++;
        SceneManager.LoadScene("level" + currentScene.ToString());
    }
}
