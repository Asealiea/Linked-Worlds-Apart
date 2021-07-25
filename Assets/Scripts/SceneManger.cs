using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class SceneManger : MonoBehaviour
{
    private void Update()
    {
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false; // makes it stop while in test play
#else
		    Application.Quit();// quits the game (only works after it's been built)
#endif
        }
    }



public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false; // makes it stop while in test play
#else
		    Application.Quit();// quits the game (only works after it's been built)
#endif
        }
    }

}
