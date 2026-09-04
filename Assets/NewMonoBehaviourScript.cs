using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI textbox;

    public void ButtonClickMethod()
    {
        textbox.text = "I have changed";
    }
}
