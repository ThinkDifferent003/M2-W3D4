using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DAMAGE_TYPE 
{
    SLASHING = 0,
    PIERCING = 1,
    BLUDGEONING = 2,
    MAGICAL = 3,
    FORCE = 4,
}
public class DamageTypeExample : MonoBehaviour
{
    [SerializeField] private DAMAGE_TYPE attackType;
    [SerializeField] private DAMAGE_TYPE resistance;
    [SerializeField] private DAMAGE_TYPE weakness;
    [SerializeField] private int baseDamage;
    // Start is called before the first frame update
    void Start()
    {
      
       // if (attackType == resistance)
       // {
            //baseDamage = baseDamage/2;
            //Debug.Log("Il nemico è resistente");
       // }
       // else if (attackType == weakness)
       // {
            //baseDamage = baseDamage*2;
            //Debug.Log("Il nemico è debole");
       // }

        // adesso con lo switch
       switch (attackType)
        {
            case DAMAGE_TYPE.SLASHING:
                Attacco(attackType, resistance, weakness, baseDamage);
                break;
            case DAMAGE_TYPE.PIERCING:
                Attacco(attackType, resistance, weakness , baseDamage);
                break;
            case DAMAGE_TYPE.MAGICAL:
                Attacco(attackType , resistance, weakness , baseDamage); 
                break;
            case DAMAGE_TYPE.FORCE:
                Attacco(attackType , resistance , weakness , baseDamage);
                break;
            case DAMAGE_TYPE.BLUDGEONING:
                Attacco(attackType , resistance , weakness , baseDamage);
                break;
        }
    }

    void Attacco(DAMAGE_TYPE attacktype , DAMAGE_TYPE resistance ,DAMAGE_TYPE weakness ,int baseDamage)
    {
        if (attackType == resistance)
        {
            baseDamage = baseDamage*2;
            Debug.Log("Il nemico è resistente");
        }
        else if (attackType == weakness)
        {
            baseDamage = baseDamage*2;
            Debug.Log("Il nemico è debole");
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
