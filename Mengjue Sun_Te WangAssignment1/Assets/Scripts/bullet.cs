using UnityEngine;


using UnityEngine.UI;

using System.Collections;

public class bullet : MonoBehaviour
{

    private int count;
   
   
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {

            other.gameObject.SetActive(false);

        }


    }
}