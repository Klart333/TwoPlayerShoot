using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Gubbe2 : GubbMovement
{
    protected override void Start()
    {
        base.Start();
        upKey = "w";
        downKey = "s";
        leftKey = "a";
        rightKey = "d";
        bodgeP2 = 180;
    }
    protected override void Update()
    {
        base.Update();
    }
}
