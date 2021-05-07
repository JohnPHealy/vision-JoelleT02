using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotebookManager : MonoBehaviour
{
    public ScoreScript score;
    public GameObject activate2;
    public GameObject activate3;
    public GameObject activate4;
    public GameObject activate5;
    public GameObject activateGlasses;

    
    void Update()
    {
        switch (score.ScoreNum)
        {
            case 1:
                activate2.SetActive(true);
                break;
            case 2:
                activate3.SetActive(true);
                break;
            case 3:
                activate4.SetActive(true);
                break;
            case 4:
                activate5.SetActive(true);
                break;
            case 5:
                activateGlasses.SetActive(true);
                break;
        }
    }
    
}
