using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDeactivation : MonoBehaviour
{
    public GameObject Door;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Door.SetActive(false);
        }
    }
}
