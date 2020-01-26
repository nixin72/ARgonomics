using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionSplash : MonoBehaviour
{
    public float delayBeforeLoading = 10f;
    public string sceneNameToLoad;
    public float timeElapsed;

    // Update is called once per frame
    public void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > delayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
