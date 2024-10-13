using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtObjectEx : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        // public void LookAt(Transform target);
        transform.LookAt(target);

        // public void LookAt(Transform target, Vector3 worldUp = Vector3.up);
        //transform.LookAt(target, Vector3.left);

        // public void LookAt(Vector3 worldPosition);
        //transform.LookAt(Vector3.zero);
    }
}
