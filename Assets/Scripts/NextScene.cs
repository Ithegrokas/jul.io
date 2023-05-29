using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] private int currentScene = 0;
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (SceneManager.sceneCountInBuildSettings - 1 <= currentScene)
            {
                SceneManager.LoadScene("Level" + currentScene.ToString());
                currentScene++;
            }
            else
            {
                SceneManager.LoadScene("Start");
            }
        }

    }
}
