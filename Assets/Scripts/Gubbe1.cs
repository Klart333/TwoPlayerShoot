using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gubbe1 : GubbMovement
{
    protected override void Start()
    {
        base.Start();
        upKey = "w";
        downKey = "s";
        leftKey = "a";
        rightKey = "d";
        
    }
    protected override void Update()
    {
        base.Update();
    }

}
