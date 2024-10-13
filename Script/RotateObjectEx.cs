using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class RotateObjectEx : MonoBehaviour
{
    public float xAngle, yAngle, zAngle;

    private GameObject cube1, cube2;

    void Awake()
    {
        cube1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube1.transform.position = new Vector3(5, 0, 0);
        cube1.transform.Rotate(90, 0, 0, Space.Self);
        cube1.GetComponent<Renderer>().material.color = Color.red;
        cube1.name = "Self";

        cube2 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube2.transform.position = new Vector3(-5, 0, 0);
        cube2.transform.Rotate(90, 0, 0, Space.World);
        cube2.GetComponent<Renderer>().material.color = Color.green;
        cube2.name = "World";
    }

    void Update()
    {

        /* Declaration */
        // public void Rotate(Vector3 eulers, Space relativeTo = Space.Self);
        cube1.transform.Rotate(Vector3.down, Space.Self);


        /* Declaration */
        // public void Rotate(float xAngle, float yAngle, float zAngle, Space relativeTo = Space.Self);
        cube2.transform.Rotate(xAngle, yAngle, zAngle, Space.World);
    }
}
