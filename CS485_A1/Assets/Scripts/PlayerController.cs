using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{   // Initialize all the variables
    public float speed;
    public Text countText;
    public Text winText;

    private Rigidbody rb;
    private int count;
    
    void Start () // Use this for initialization
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winText.text = "";
    }

    // Use this for initialization all the physics code
    void FixedUpdate() // call before performing any physics calculations
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other) // To get a hold of the colliders that be touched
    { // this function will be called when the player touch the object
        if (other.gameObject.CompareTag("Pick Up")) // check the tag based on condition
        { // If it is the same string value, it will continue the process (go to next condition)
             // when condition meet, it will deactivate the game object
                other.gameObject.SetActive(false);
                count = count + 1;
                SetCountText();
        }
    }
    
    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 12)
        {
            winText.text = "You Win!";
        }
    }
}
