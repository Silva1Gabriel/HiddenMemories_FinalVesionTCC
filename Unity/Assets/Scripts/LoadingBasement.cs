﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingBasement : MonoBehaviour {

    void Update()
    {
        // Delay para carregar o level do porão ("Basement");
        StartCoroutine(WaitForNewSceneLoad());
    }

    private IEnumerator WaitForNewSceneLoad()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Basement");
    }
}