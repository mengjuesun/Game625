using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBottle : PickUps
{
    private int score = -3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void AddScore()
    {
        WinOrLose.instance.count += score;
        WinOrLose.instance.SetCountText();
    }
}
