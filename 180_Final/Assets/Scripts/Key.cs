using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Vector3 rotation;
    [SerializeField] private float Speed;


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * Speed * Time.deltaTime);
    }
}
