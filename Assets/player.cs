using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int jumpForce = 5;
    bool hasJump;
    Rigidbody RB;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && hasJump)
        {
            RB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            hasJump = false;
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        hasJump = true;
        Debug.Log("HOLA!");
    }
}
 