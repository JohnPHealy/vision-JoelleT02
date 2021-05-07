using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Experimental.Rendering.LWRP;

public class ScoreScript : MonoBehaviour
{
    public Text ScoreText;
    public Text GlassesText;
    public int ScoreNum;
    public int GlassesGot;
    public GameObject notebook2;
    public GameObject notebook3;
    public GameObject notebook4;
    public GameObject notebook5;
    public GameObject glasses;
    
    public PlayerHealth heal;
    public HealthBar fullbar;
    
    public UnityEngine.Experimental.Rendering.Universal.Light2D Sight;
    public UnityEngine.Experimental.Rendering.Universal.Light2D Spotlight;

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
            Sight.intensity = 1;
            Spotlight.intensity = 0;
            heal.currentHealth = 10;
            fullbar.SetHealth(heal.currentHealth);
        }
            
    }
}