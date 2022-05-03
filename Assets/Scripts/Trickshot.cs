using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Trickshot : MonoBehaviour
{
    bool trickshotnow = true;
    // Start is called before the first frame update
    void Start()
    {
        trickshotnow = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!trickshotnow){
            return; 
        }else{
            StartCoroutine(check());
        }
    }

    IEnumerator check(){

        if (Math.Round(transform.rotation.eulerAngles.z, 1) > 175 && Math.Round(transform.rotation.eulerAngles.z, 1) < 180 && trickshotnow)
        {
            
            text.scoreVal++;
            trickshotnow = false;
            yield return new WaitForSeconds(.5f);
            trickshotnow = true;

        }
    }
}
