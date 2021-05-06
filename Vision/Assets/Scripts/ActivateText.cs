using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateText : MonoBehaviour
{
    public TextAsset theText;

    public int startLine;
    public int endLine;

    public TextBoxManager theTextBox;

    public bool requireButtonPress;
    private bool waitForPress;

    public bool destroyWhenActivated;
    
    public Text ScoreText;
    private int ScoreNum;
    

    void Start()
    {
        theTextBox = FindObjectOfType<TextBoxManager>();
        ScoreNum = 0;
        ScoreText.text = "Notebooks: " + ScoreNum;
        
    }

    void Update()
    {
        if (waitForPress && Input.GetKeyDown(KeyCode.Return))
        {
            theTextBox.ReloadScript(theText);
            theTextBox.currentLine = startLine;
            theTextBox.endAtLine = endLine;
            theTextBox.EnableTextBox();
            ScoreNum += 1;
            ScoreText.text = "Notebooks: " + ScoreNum;

            if (destroyWhenActivated)
            {
                Destroy(gameObject);
            }
            
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            if (requireButtonPress)
            {
                waitForPress = true;
                return;
            }

            theTextBox.ReloadScript(theText);
            theTextBox.currentLine = startLine;
            theTextBox.endAtLine = endLine;
            theTextBox.EnableTextBox();
            ScoreNum += 1;
            ScoreText.text = "Notebooks: " + ScoreNum;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            waitForPress = false;
        }
    }
}
