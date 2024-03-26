using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchScenes : MonoBehaviour
{
    public void Switch()
    {
        Debug.Log("clicked");
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            SceneManager.LoadScene(0);
            Debug.Log("0");
        }
        else
        {
            SceneManager.LoadScene(1);
            Debug.Log("1");
        }
        
    }
}