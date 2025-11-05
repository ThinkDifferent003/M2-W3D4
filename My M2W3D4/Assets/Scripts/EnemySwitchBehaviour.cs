using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum STATE
{
    IDLE = 0,
    AGGROED = 1,
    ATTACKING = 2,
    DEFEATED = 3,
}
public class EnemySwitchBehaviour : MonoBehaviour
{
    [SerializeField] private STATE state;
  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       // if (state == STATE.IDLE)
       // {
          //  Debug.Log("Il nemico è fermo");
       // }
       // else if (state == STATE.ATTACKING)
       // {
          //  Debug.Log("Il nemico sta attaccando il giocatore");

       // }
       // else if (state == STATE.AGGROED)
       // {
          //  Debug.Log("Il nemico insegue il giocatore");

       // }
       // else if (state == STATE.DEFEATED)
       // {
          //  Debug.Log("Il nemico è stato sconfitto");

       // }

        //adesso con switch
        switch (state)
        {
            case STATE.IDLE:
                Debug.Log("Il nemico è fermo");
                break;
            case STATE.ATTACKING:
                Debug.Log("Il nemico sta attaccando");
                break;
            case STATE.AGGROED:
                Debug.Log("Il nemico insegue il giocatore");
                break;
            case STATE.DEFEATED:
                Debug.Log("Il nemico è sconfitto");
                break;
        }
    }
}








