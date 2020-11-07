using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text textBox;
    public LogController controller;
    public LogTextType type;

    public void ClickEvent()
    {
        controller.InitNewTextBasedOnType(textBox.text, type);
    }
}
