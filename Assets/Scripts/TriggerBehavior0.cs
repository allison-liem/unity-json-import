using UnityEngine;
using UnityEngine.UI;

public class TriggerBehavior0 : MonoBehaviour
{
    private Text uiText;

    void Start()
    {
        uiText = FindObjectOfType<Text>();
    }

    void OnTriggerEnter2D(Collider2D _)
    {
        uiText.text = "Sara is in the trigger";
        uiText.fontSize = 36;
        uiText.fontStyle = FontStyle.Bold;
    }

    void OnTriggerExit2D(Collider2D _)
    {
        uiText.text = "Sara is no longer in the trigger";
        uiText.fontSize = 30;
        uiText.fontStyle = FontStyle.Normal;
    }
}
