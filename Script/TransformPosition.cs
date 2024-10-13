using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TransformPosition : MonoBehaviour
{
    public float force = 10f;

    public Transform pivotPoint;
    public float rotationSpeed = 100f;

    public float scaleFactor = 1.1f;

    void Start()
    {
        // Cara 1: Menggunakan GetComponent<Transform>()
        Transform myTransform = GetComponent<Transform>();
        myTransform.position = new Vector3(10, 10, 10);

        // Cara 2: Menggunakan transform secara langsung
        transform.position += new Vector3(0, 5, 0);
        transform.rotation = Quaternion.Euler(0, 45, 0);
        transform.localScale = new Vector3(4, 2, 1);


    }

    void Update()
    {
        MovingObject();
        RotateObject();
        ScaleObject();
    }

    private void MovingObject()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float depthInput = Input.GetAxis("Depth");

        Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, depthInput);
        transform.Translate(moveDirection * force * Time.deltaTime);
    }

    private void RotateObject()
    {
        if (Input.GetMouseButton(0))
        {
            float horizontalInput = Input.GetAxis("Mouse X");
            float verticalInput = Input.GetAxis("Mouse Y");

            transform.RotateAround(pivotPoint.position, Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
            transform.RotateAround(pivotPoint.position, Vector3.right, verticalInput * rotationSpeed * Time.deltaTime);
        }
    }

    private void ScaleObject()
    {
        if (Input.GetMouseButton(1))
        {
            float horizontalInput = Input.GetAxis("Mouse X");
            // float verticalInput = Input.GetAxis("Mouse Y");

            if (horizontalInput >= .01f)
            {
                transform.localScale *= scaleFactor * Time.deltaTime;
            }
            else if (horizontalInput <= .01f)
            {
                transform.localScale /= scaleFactor * Time.deltaTime;
            }
        }
    }
}
