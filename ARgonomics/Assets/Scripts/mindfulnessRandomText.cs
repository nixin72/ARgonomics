using UnityEngine;
using UnityEngine.UI;

public class mindfulnessRandomText : MonoBehaviour
{
    public Text mytext = null;
    string[] textArray = { "Take a 15 minute walk.", "Medidate.", "Eat a fruit.", "Take a nap.", "Take a deep breath.", "Drink water.", "Go for a jog.", "Eat a fruit.", "Listen to: You make my dreams come true by Hall and Oates.", "Give a beautiful smile!"};
    // Start is called before the first frame update
    void Start()
    {
        int randomNumber = Random.Range(0, 10);
        mytext.text = textArray[randomNumber];
    }
}
