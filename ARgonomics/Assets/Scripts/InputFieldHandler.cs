﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputFieldHandler : MonoBehaviour
{

    public UnityEngine.UI.InputField inputField;
    private GameObject chairButton;
    private GameObject deskButton;

    // Start is called before the first frame update
    void Start()
    {
        chairButton = GameObject.Find("Desk");
        deskButton = GameObject.Find("Chair");
        chairButton.SetActive(false);
        deskButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(ValidateInput(inputField.text))
        {
            PlayerPrefs.SetString("Height", inputField.text);
        }
    }

    public bool ValidateInput(string str)
    {
        var isNumeric = int.TryParse(str, out int num);
        if (isNumeric && num > 0f && num < 300f)
        {
            Color green = new Color(175/255f, 1f, 150/255f);
            inputField.image.color = Color.green;
            //activate buttons
            deskButton.SetActive(true);
            chairButton.SetActive(true);
            return true;
        }
        else
        {
            Color red = new Color(1f, 150/255f, 150/255f);
            inputField.image.color = red;
            //deactivate buttons
            deskButton.SetActive(false);
            chairButton.SetActive(false);
            return false;
        }
    }

}
