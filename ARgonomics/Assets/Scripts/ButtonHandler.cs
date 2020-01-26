using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public void OnDesk()
    {
        _ShowAndroidToastMessage("onDesk");
    }

    public void OnChair()
    {
        _ShowAndroidToastMessage("onDesk");
    }

    public void OnMindfullness()
    {
        _ShowAndroidToastMessage("onDesk");
    }

    public void OnExit()
    {
        Application.Quit(0);
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
