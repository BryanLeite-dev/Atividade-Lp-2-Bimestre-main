using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigopulo : MonoBehaviour
{
    public float jumpForce;
    private Rigidbody rigidbody;
    private bool isGround = false;

    void Start ()
    {
        rigidbody = GetComponent<Rigidbody>();
       

    }

    void Update()
    {
        if(!Input.GetKeyDown(KeyCode.Space) || !isGround)
        return;

        rigidbody.AddForce(
            new Vector2(0,jumpForce),
            ForceMode.Impulse
        );
    }

    void OnCollisionEnter(Collision collision)
    {
        isGround = true;
    }

    void OnCollisionExit(Collision collision)
    {
        isGround = false;
    }
}