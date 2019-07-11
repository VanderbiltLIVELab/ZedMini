using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private static int count;

    public float speed;
    private Rigidbody rb;
    
    void Start () {
        rb = GetComponent<Rigidbody>();

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Target") { 
            collision.gameObject.SetActive(false);
            count++;

            if (count == 6)
            {
                Debug.Log("You Win!");
            }
        }
    }

    void Update() {
        
    }
    
    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(force * speed);
    }
}