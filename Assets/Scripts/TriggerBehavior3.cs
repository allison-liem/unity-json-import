using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class TriggerBehavior3 : MonoBehaviour
{
    private Text uiText;

    public string enterJsonPath = "Json/enter";
    public string exitJsonPath = "Json/exit";
    private Trigger enterTrigger;
    private Trigger exitTrigger;

    void Start()
    {
        uiText = FindObjectOfType<Text>();
        enterTrigger = JsonUtils.ImportJson<Trigger>(enterJsonPath);
        exitTrigger = JsonUtils.ImportJson<Trigger>(exitJsonPath);
    }

    void OnTriggerEnter2D(Collider2D _)
    {
        SetUiText(enterTrigger);
    }

    void OnTriggerExit2D(Collider2D _)
    {
        SetUiText(exitTrigger);
    }

    private void SetUiText(Trigger trigger)
    {
        uiText.text = trigger.text;
        uiText.fontSize = trigger.font.size;
        if (trigger.font.style.Equals("italic"))
        {
            uiText.fontStyle = FontStyle.Italic;
        } else
        {
            uiText.fontStyle = FontStyle.Normal;
        }
    }
}
