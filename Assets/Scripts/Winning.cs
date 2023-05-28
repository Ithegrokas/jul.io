using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private int currentScene = 0;
    // Update is called once per frame
    void Update()
    {
        SceneManager.LoadScene("level" + currentScene.ToString());
        currentScene++;
    }
}
