using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashGame : MonoBehaviour
{
    [SerializeField] float deleyCrash = 1f;
    [SerializeField] ParticleSystem crashParticle;
    bool hasCrashed=false;
    void OnTriggerEnter2D(Collider2D other )
    {
        if (other.tag == "Crash" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<ControlPlayer>().DisableControls();
            crashParticle.Play();
            GetComponent<AudioSource>().Play();
            Invoke("CrashReloadScene", deleyCrash);
        }   
    }
    void CrashReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
