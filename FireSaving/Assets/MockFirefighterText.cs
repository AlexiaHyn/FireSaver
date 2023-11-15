using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;

public class MockFirefighterText : MonoBehaviour
{
    public TextMeshProUGUI one;
    public TextMeshProUGUI two;
    string twoStr;
    Stopwatch timer = new Stopwatch();

    // Start is called before the first frame update
    void Start()
    {
        twoStr = two.text;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.ElapsedMilliseconds > 2500)
        {
            timer.Restart();
            timer.Stop();
            one.text = "#155.500:\n";
            if (two.text == "#438.500 (You):\nHEADING UP")
            {
                one.text += "I'M FOLLOWING";
                two.text = "#438.500 (You):\n[Awaiting response...]";
            }
            if (two.text == "#438.500 (You):\nSTOP HERE")
            {
                one.text += "CAREFUL!";
                two.text = "#438.500 (You):\n[Awaiting response...]";
            }
            if (two.text == "#438.500 (You):\nROGER THAT")
            {
                one.text += "2 INJURED, SECOND FLOOR";
                two.text = "#438.500 (You):\n[Awaiting response...]";
            }
        }
        if (twoStr != two.text)
        {
            timer.Start();
            twoStr = two.text;
        }
    }
}
