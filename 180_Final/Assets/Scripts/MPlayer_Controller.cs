using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MPlayer_Controller : MonoBehaviour
{
    /* Mateo Jimenez
     * 12/3/2024
     * handles player view control 
     */

    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;




    // Start is called before the first frame update
   
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    //camera will follow mouse cursor
    private void Update()
    {

        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;

        //limits vertical rotation
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);


        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);   
    }

}
