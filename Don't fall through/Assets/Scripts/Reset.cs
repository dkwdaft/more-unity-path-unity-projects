using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    [SerializeField] private Button resetButton;

    private void Awake()
    {
        resetButton.onClick.AddListener(() => Application.LoadLevel(Application.loadedLevel));
    }
}
