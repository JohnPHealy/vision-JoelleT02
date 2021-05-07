using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text ScoreText;
    public Text GlassesText;
    public int ScoreNum;
    private int GlassesGot;
    public GameObject notebook2;
    public GameObject notebook3;
    public GameObject notebook4;
    public GameObject notebook5;
    public GameObject glasses;

    void Start()
    {
        ScoreNum = 0;
        GlassesGot = 0;
        ScoreText.text = "Notebooks: " + ScoreNum;
        notebook2.SetActive(false);
        notebook3.SetActive(false);
        notebook4.SetActive(false);
        notebook5.SetActive(false);
        glasses.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "NoteBook")
        {
            ScoreNum ++;
            Destroy(other.gameObject);
            ScoreText.text = "Notebooks: " + ScoreNum;
        }

        if (other.tag == "Glasses")
        {
            GlassesGot++;
            Destroy(other.gameObject);
            GlassesText.text = "Glasses: " + GlassesGot;
        }
            
    }
}