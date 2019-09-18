using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int NailCount;

    public Text text;

    void Start ()
    {
        NailCount = 0;
    }

    void Update ()
    {
        text.text = "High Score: " + NailCount.ToString();
    }
}
