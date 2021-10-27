using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Label : MonoBehaviour
{
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "";
    }

    // Update is called once per frame
    public void UpdateText(int id)
    {
        string txt = "";

        switch (id)
        {
            case 0:
                txt = "Lemon Peel";
                break;

            case 1:
                txt = "Orange Peel";
                break;

            case 2:
                txt = "Raspberry";
                break;

            case 3:
                txt = "Sugar";
                break;

            case 4:
                txt = "Gin";
                break;

            case 5:
                txt = "Vermouth";
                break;

            case 6:
                txt = "Vodka";
                break;

            case 7:
                txt = "Whiskey";
                break;
        }

        text.text = txt;
    }

    public void RemoveText()
    {
        text.text = "";
    }
}
