using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FireController : MonoBehaviour
{
    public GameObject shellPrefab;
    public KeyCode fireKey = KeyCode.Space;
    public float shellSpeed = 20;
    public GameObject bulletPrefab;

    private Transform firePosition;
    public int bulletnumber = 8;
    public Text bulletnumberText;
    public Text SBText;

    
    void Start()
    {
        firePosition = transform.Find("Fireposition");
        setbulletnumberText();
        SBText.text = "";
    }

    
    void Update()
    {
        if (Input.GetKeyDown(fireKey))
        {
            GameObject Player = GameObject.Instantiate(shellPrefab, firePosition.position, firePosition.rotation) as GameObject;
            Player.GetComponent<Rigidbody>().velocity = Player.transform.forward * shellSpeed;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (bulletnumber > 0)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                bulletnumber = bulletnumber - 1;
                setbulletnumberText();
                Destroy(bullet, 10f);
                setreloadText();
            }
        }

    }
    private void setbulletnumberText()
    {
        bulletnumberText.text = "bullet number:" + bulletnumber.ToString();

    }
    private void setreloadText()
    {
        if (bulletnumber == 0)
        {
            SBText.text = "You ran out of weapons, lol";
            if (bulletnumber > 0)
            {
                Destroy(SBText);
            }

        }
        else
        {
            SBText.text = "";
        }
    }
}