using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetsPlayWithArrays : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int index = 0;
        int times = 2;
        int[] arrayNew = {1,2,3,4,5}; 
        Debug.Log($"Valori iniziali");
        Stampa(arrayNew);

        
        //int value = Find(arrayNew,4);
        //if (value != -1)
        //{
        //    Debug.Log($"TROVATO {value}");
        //}
       
        
        
        //PutToTheBack(arrayNew, index);
        //Debug.Log($"Valori dopo ");
        //Stampa(arrayNew);


        //ShiftOnce(arrayNew);
        //Debug.Log($"Valori dopo");
        //Stampa(arrayNew);


        Shift(arrayNew, times);
        Debug.Log($"Valori dopo");
        Stampa(arrayNew);

    }
    void Stampa(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log($"Indice : {i} e valori {array[i]}");
        }
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
        return -1;
        
        
    }
    void PutToTheBack(int[] array, int index)
    {
        index = array[2];

        for (int i = 2 ; i < array.Length - 1; i++)
        {
            array[i] = array[i + 1];

           
        }
        array[array.Length - 1] = index;
    }
    void ShiftOnce(int[] array)
    {
        int last = array.Length;
        for (int i = array.Length-1;i>0;i --)
        {
            array[i] = array[i-1];
        }
        array[0] = last;
        
    }
    void Shift (int[] array , int times)
    {
        
        int last = array.Length-1;
        while(times > 0)
        {
            int i = array.Length - 1;
            times--;
            while (i > 0)
            {
                array[i] = array[i - 1];
                array[0] = last;

            }
            
        }
        Debug.Log (array.Length);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
