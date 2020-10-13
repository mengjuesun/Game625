using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    ICommand moveRight, moveLeft;
    [SerializeField]
    private float Speed = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            moveLeft = new MoveLeftCommand(this.transform, Speed);
            moveLeft.Execute();
        }
        else if(Input.GetKeyDown(KeyCode.E))
        {
            moveRight = new MoveRightCommand(this.transform, Speed);
            moveRight.Execute();
        }
 
    }
}
