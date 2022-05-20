using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class codigomovimento : MonoBehaviour
{
    public float velocity;
    public float rotation;

    void Start ()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");

        Vector3 dir = new Vector3(x, 0, y) * velocity;
        transform .Translate (dir * Time.deltaTime);
        transform.Rotate(new Vector3(
            0,
            mouseX * rotation * Time.deltaTime,
            0
        ));
    }
}
