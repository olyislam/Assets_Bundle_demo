﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandeller : MonoBehaviour
{
    public void LoadScene(int indx)
    {
        SceneManager.LoadScene(indx);
    }

    public static void LoadScene(string name)
    {
        Debug.Log("LOADED");
        SceneManager.LoadScene(name);
    }
}