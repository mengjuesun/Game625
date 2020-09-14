using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closet : OceanFloat
{
    public override void ColWithPlayer(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            Destroy(this.gameObject);
            
        }
    }
}
