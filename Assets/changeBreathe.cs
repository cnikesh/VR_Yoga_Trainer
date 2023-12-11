using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changeBreathe : MonoBehaviour
{
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeText()
    {
        if(text.text == "INHALE")
        {
            text.SetText("EXHALE");
        }
        else
        {
            text.SetText("INHALE");
        }
    }
}
