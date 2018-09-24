using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour 
{ // Use this class to rotate the pick up object
    void Update() // Update is called once per frame
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }	
}
