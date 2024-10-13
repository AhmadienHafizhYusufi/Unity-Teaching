using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObjectEx : MonoBehaviour
{
    void Update()
    {
        /* Declaration */
        // public void Translate(Vector3 translation);
        transform.Translate(Vector3.forward * Time.deltaTime);

        /* Declaration */
        // public void Translate(Vector3 translation, Space relativeTo = Space.Self);
        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }
}
