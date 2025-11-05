using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeDivideExercise : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    // Start is called before the first frame update
    void Start()
    {
        int risultato;
        bool ok = SafeDivide(a, b, out risultato);
        if (ok)
        {
            Debug.Log(risultato);
        }
        else
        {
            Debug.LogWarning("WARNING il divisore non può essere uguale a 0");
        }
    }
    bool SafeDivide (int dividendo,int divisore, out int risultato)
    {
        if (divisore == 0)
        {
            risultato = 0;
            return false;
        }
        else 
        {
            risultato = dividendo/divisore;
            return true;

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
