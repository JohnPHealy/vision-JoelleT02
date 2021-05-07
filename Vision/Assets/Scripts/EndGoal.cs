using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGoal : MonoBehaviour
{
    public ScoreScript glasses;

    private void OnTriggerEnter2D(Collider2D goal)
    {
        if (glasses.GlassesGot == 1)
        {
            SceneManager.LoadScene("Victory Screen");
        }
    }
}
