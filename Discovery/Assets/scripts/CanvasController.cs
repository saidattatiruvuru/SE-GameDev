﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class CanvasController : MonoBehaviour
{
    public void PauseGame()
    {
        SceneManager.LoadScene(0);
    }
}
