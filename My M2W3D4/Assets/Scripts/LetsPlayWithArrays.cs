using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetsPlayWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int Find (int[] array,int value)
    {
        for (int i = 0; i < array.Length; i++)
        {
           if (array[i] == value)
            {
               return i;
            }
        }
        return value;
    }
    void PutToTheBack(int[] array, int index)
    {
        int[] newarray = new int [5];
        index = newarray[2];
        for (int i = 0; i < 6 ;i++ )
        {
            if ( i == index)
            {
                index = array.Length + 1;
            }
        }

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
