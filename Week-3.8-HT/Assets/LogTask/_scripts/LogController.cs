using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public struct NewTextArgs
{
    public string textToWrite;
    public Color color;
    public float TimeToDelete;
    public int FontSize;

    public NewTextArgs(string text, Color c , float time, int fontSize)
    {
        textToWrite = text;
        color = c;
        TimeToDelete = time;
        FontSize = fontSize;
    }
}

public enum LogTextType
{
    defaultText,
    warningText,
    yellText
}


public class LogController : MonoBehaviour
{
    public List<GameObject> LogTexts;
    public GameObject TextPrefab;

    void Start()
    {
        LogTexts = new List<GameObject>();

        InitNewTextBasedOnType("BOSS IS HERE, BE READY", LogTextType.defaultText);
        InitNewTextBasedOnType("BOSS IS HERE, BE READY", LogTextType.warningText);
        InitNewTextBasedOnType("BOSS IS HERE, BE READY", LogTextType.yellText);
    }

    void Update()
    {
        UpdateLogTextPosition();
    }

    void UpdateLogTextPosition()
    {
        float SumYoffset = 0;

        for (int i = 0; i < LogTexts.Count; i++)
        {
            if (LogTexts[i] == null)
            {
                LogTexts.RemoveAt(i);
                i--;
                continue;
            }

            LogTexts[i].transform.localPosition = new Vector2(LogTexts[i].transform.localPosition.x, -SumYoffset);
            SumYoffset += LogTexts[i].GetComponent<RectTransform>().rect.height + 10;
        }
    }

    void InitNewText(NewTextArgs args)
    {
        LogTexts.Add(Instantiate(TextPrefab));
        LogTexts[LogTexts.Count - 1].GetComponent<TextScript>().WriteText(args);
        LogTexts[LogTexts.Count - 1].transform.parent = this.transform;
    }

    public void InitNewTextBasedOnType(string text, LogTextType type)
    {
        switch (type)
        {
            case LogTextType.defaultText:
                NewTextArgs Dargs = new NewTextArgs(text, Color.white, 10f, 20);
                InitNewText(Dargs);
                break;
            case LogTextType.warningText:
                NewTextArgs Wargs = new NewTextArgs(text, Color.yellow, 15f,20);
                InitNewText(Wargs);
                break;
            case LogTextType.yellText:
                NewTextArgs Yargs = new NewTextArgs(text, Color.red, 20f,30);
                InitNewText(Yargs);
                break;


        }

    }
}
