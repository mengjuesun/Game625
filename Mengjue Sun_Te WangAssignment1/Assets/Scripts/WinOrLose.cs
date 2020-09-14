using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinOrLose : MonoBehaviour
{
    public static WinOrLose instance;

    public Text countText;
    public Text winText;
    public Text loseText;
    public int count;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

        count = 0;

        SetCountText();

        winText.text = "";
        loseText.text = "";
    }

    // Update is called once per frame
    
    public void SetCountText()
    {
        countText.text = "Count: " + count.ToString();

        if (count >= 12)
        {
            winText.text = "You Win!";

        }

        if (count <= -1)
        {
            SetLoseText();
        }
    }

    public void SetLoseText() {
        loseText.text = "You Lose!";
    }
}
