﻿using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int Score;


    Text _text;


    void Awake ()
    {
        _text = GetComponent <Text> ();
        Score = 0;
    }


    void Update ()
    {
        _text.text = "Score: " + Score;
    }
}
