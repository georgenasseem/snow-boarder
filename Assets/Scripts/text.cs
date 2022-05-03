using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class text : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int scoreVal;


    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        scoreVal = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreVal;
    }
}
