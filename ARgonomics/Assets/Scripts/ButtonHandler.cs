using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonHandler : MonoBehaviour
{

    public void SceneLoader (int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
}
