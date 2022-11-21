using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;

public class CountScore : MonoBehaviour
{
    public GameObject score_object = null;
    public int score_num = 0;

    void Start()
    {   
        TextMeshPro score_text = score_object.GetComponent<TextMeshPro> ();
        score_text.text = "Score: " + score_num; 
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshPro score_text = score_object.GetComponent<TextMeshPro> ();
        score_text.text = "Score: " + score_num; 
    }
}
