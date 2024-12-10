using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


/* Mateo Jimenez
 * 12/10/2024
 * Handles enemy movement
 */

public class Enemy : MonoBehaviour
{
    public Transform Player;

    int MoveSpeed = 6;

    int MaximumDistance = 12;
    float MinimumDistance = .5f;

   
    void Update()
    {
       
        transform.LookAt(Player);

        if(Vector3.Distance(transform.position, Player.position) >= MinimumDistance && Vector3.Distance(transform.position, Player.position) <= MaximumDistance)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            
        }
       

        
    }

    
}
