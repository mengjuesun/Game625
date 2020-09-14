using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanFloat : MonoBehaviour
{
    public virtual void ColWithPlayer(Collision collision)
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
            ColWithPlayer(collision);
        
    }
}
