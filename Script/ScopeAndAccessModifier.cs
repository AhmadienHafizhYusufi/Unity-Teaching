using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccessModifier : MonoBehaviour
{
    void Start()
    {
        // Local scope: accessible only within the Start method
        int localVariable = 0;
    }

    void Update()
    {
        // Local scope: accessible only within the Update method
        int anotherLocalVariable = 0;
    }

    // Class scope: accessible by all methods within the PositionObjectEx class
    private int classVariable;
}
