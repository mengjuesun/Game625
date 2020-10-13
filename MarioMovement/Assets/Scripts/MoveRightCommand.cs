using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightCommand : ICommand
{
    private Transform Player;
    private float Speed;

    public MoveRightCommand(Transform player, float speed)
    {
        this.Player = player;
        this.Speed = speed;
    }

    public void Execute()
    {
        Player.Translate(Vector2.right * Speed * Time.deltaTime);
    }

}
