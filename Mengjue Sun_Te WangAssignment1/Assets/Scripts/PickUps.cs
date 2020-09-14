using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PickUps : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public abstract void AddScore();

    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player") {
            gameObject.GetComponent<Collider>().enabled = false;
            transform.parent.parent.gameObject.SetActive(false);
            AddScore();
        }
    }

}
