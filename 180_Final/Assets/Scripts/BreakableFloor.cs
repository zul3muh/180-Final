using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 * Name: Arianna Reyes
 * Date: 12/3/2024
 * This handles the function of the breakable floor trap
 */
public class BreakableFloor : MonoBehaviour
{
    
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<MPlayer_Movement>())
            StartCoroutine(BreakFloor());
    }
    

    IEnumerator BreakFloor()
    {
        yield return new WaitForSeconds(1f);
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;

        yield return new WaitForSeconds(3f);
        GetComponent<BoxCollider>().enabled = true;
        GetComponent <MeshRenderer>().enabled = true;
    }




}
