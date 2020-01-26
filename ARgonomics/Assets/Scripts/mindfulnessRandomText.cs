using UnityEngine;
using UnityEngine.UI;

public class mindfulnessRandomText : MonoBehaviour
{
    public Text mytext = null;
    string[] textArray = { "Take a walk.", "Medidate.", "Eat a fruit.", "Take a nap.", "Breath deeply.", "Drink water.", "Go for a jog.", "Eat a fruit.", "Listen to music.", "Give a smile!"};
    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = Random.Range(0, 10);
        mytext.text = textArray[randomNumber];
    }
}
