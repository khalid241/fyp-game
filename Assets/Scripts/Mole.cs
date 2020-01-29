using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mole : MonoBehaviour
{
    public GameObject onHit;

    private Score scorescript;
    

    void Awake()
    {
        scorescript = GetComponent<Score>();
    }

    void OnMouseDown()
    {

        scorescript.score++;
        
        // Load On-Hit effect
        GameObject g = (GameObject)Instantiate(onHit, transform.position, Quaternion.identity);
   
        // Destroy it after a while
        Destroy(g, 0.2f);
    }
    
}
