using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    [SerializeField] private Button resetButton;

    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            ReloadScenw();
        }
    }

    private void Awake()
    {
        resetButton.onClick.AddListener(() => ReloadScenw());
    }

    private void ReloadScenw()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
