using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashGame : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Crash")
        {
            Debug.Log("You loss");
        }   
    }
}
