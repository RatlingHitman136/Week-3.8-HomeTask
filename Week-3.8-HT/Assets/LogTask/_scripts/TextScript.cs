using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class TextScript : MonoBehaviour
{
    public Text TextBox;
    public void WriteText(NewTextArgs Args)
    {
        TextBox.text = Args.textToWrite;
        TextBox.color = Args.color;
        TextBox.fontSize = Args.FontSize;
        Invoke("DestroyThis", Args.TimeToDelete);
    }

    void DestroyThis()
    {
        GameObject.Destroy(this.transform.gameObject);
    }
}
