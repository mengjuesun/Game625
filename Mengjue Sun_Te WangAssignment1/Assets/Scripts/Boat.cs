using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : OceanFloat
{

    public override void ColWithPlayer(Collision collision)
    {
        if (collision.transform.tag == "Player")
        {
            Destroy(collision.gameObject);
            WinOrLose.instance.SetLoseText();
        }
    }

}
