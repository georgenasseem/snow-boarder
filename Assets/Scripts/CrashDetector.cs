using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{ 
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;

    bool hasCrashed = false;

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Ground" && !hasCrashed)
        {
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }    
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
