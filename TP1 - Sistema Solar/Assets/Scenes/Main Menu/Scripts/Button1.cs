﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button1 : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Scene 1");
    }
}
