using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 10;
        int b = 20;
        Debug.Log(" A = " + a + " e B = " + b);
      
        Swap( a , b ); // Qua le variabili vengono solo copiate nella sua funzione ma poi non applicate nello Start
        Debug.Log(" A = " + a + " e B = " + b);
        Swap( ref a , ref b );// Con il Ref le variabili vengono proprio collegate, non sono copie , e quindi cambiano il valore anche nello Start
        Debug.Log(" A = " + a + " e B = " + b);
    }
    void Swap(int n, int m)
    {
        int swap;
        swap = m;
        m = n;
        n = swap;
        Debug.Log(" N = " + n + " e M = " + m);

    }
    void Swap(ref int n, ref int m)
    {
        int swap;
        swap=m; 
        m = n;
        n = swap;
        Debug.Log(" N = " + n + " e M = " + m);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
