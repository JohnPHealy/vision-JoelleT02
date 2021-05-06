using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text ScoreText;
    private int ScoreNum;

    void Start()
    {
        ScoreNum = 0;
        ScoreText.text = "Notebooks: " + ScoreNum;
    }

    private void OnTriggerEnter2D(Collider2D notebook)
    {
        if (notebook.tag == "NoteBook")
        {
            ScoreNum ++;
            Destroy(notebook.gameObject);
            ScoreText.text = "Notebooks: " + ScoreNum;
        }
    }
}