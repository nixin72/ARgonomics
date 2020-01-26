using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputFieldHandler : MonoBehaviour
{

    public UnityEngine.UI.InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        inputField.onValueChanged.AddListener(delegate { ValueChangedCheck(); });
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ValueChangedCheck()
    {
        ValidateInput(inputField.text);
        PlayerPrefs.SetString("Height", inputField.text);
        _ShowAndroidToastMessage(inputField.text);
    }

    private void ValidateInput(string str)
    {
        int num;
        var isNumeric = int.TryParse(str, out num);
        if(isNumeric && num > 0f && num < 300f)
        {
            inputField.image.color = Color.green;
            //activate buttons
            GameObject.Find("Desk").SetActive(true);
            GameObject.Find("Chair").SetActive(true);
        } else
        {
            inputField.image.color = Color.red;
            //deactivate buttons
            GameObject.Find("Desk").SetActive(false);
            GameObject.Find("Chair").SetActive(false);
        }
    }

    private void _ShowAndroidToastMessage(string message)
    {
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject unityActivity =
            unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        if (unityActivity != null)
        {
            AndroidJavaClass toastClass = new AndroidJavaClass("android.widget.Toast");
            unityActivity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
            {
                AndroidJavaObject toastObject =
                    toastClass.CallStatic<AndroidJavaObject>(
                        "makeText", unityActivity, message, 0);
                toastObject.Call("show");
            }));
        }
    }

}
