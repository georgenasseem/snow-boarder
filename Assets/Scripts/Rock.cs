using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rock : MonoBehaviour
{ 
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem crashRockEffect;

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            FindObjectOfType<PlayerController>().DisableControls();
            crashRockEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }    
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

