using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Name: Arianna Reyes
 * Date: 12/3/2024
 * This will handle the arrow trap functions
 */
public class ArrowTrap : MonoBehaviour
{
    public float speed;
    public bool travelRight;

    // Update is called once per frame
    void Update()
    {
        if(travelRight == true)
        {
            transform.position += speed * Vector3.right * Time.deltaTime;
        }
        else
        {
            transform.position += speed * Vector3.left * Time.deltaTime;
        }
    }
}
