using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticle;
    void OnCollisionEnter2D(Collision2D other)
    {
       
        if (other.gameObject.tag == "Crash")
        {
            dustParticle.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Crash")
        {
            dustParticle.Stop();
        }
    }
}
