using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Name: Arianna Reyes
 * Date: 12/9/2024
 * This handles the launcher functions
 */
public class Launcher : MonoBehaviour
{
    public bool travelingRight;
    public float timedArrows;
    public float beginDelay;
    public GameObject arrowPref;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("shootArrow", beginDelay, timedArrows);
    }

    public void shootArrow()
    {
        GameObject arrow = Instantiate(arrowPref, transform.position, arrowPref.transform.rotation);
        if (arrow.GetComponent<ArrowTrap>())
        {
            arrow.GetComponent<ArrowTrap>().travelRight = travelingRight;
        }
    }
}
