using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftCommand : ICommand
{
    private Transform Player;
    private float Speed;

    public MoveLeftCommand(Transform player, float speed)
    {
        this.Player = player;
        this.Speed = speed;
    }

    public void Execute()
    {
        Player.Translate(Vector2.left * Speed * Time.deltaTime);
    }

}
