using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableSwap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 20;
        Debug.Log(" A = " + a + " e B = " + b);
        int swap;
        swap = b;
        b = a;
        a = swap;
        Debug.Log(" A = " + a + " e B = " + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
