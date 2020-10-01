using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1GubbShoot : GubbShoot
{
    protected override void Start()
    {
        base.Start();
        bulletSpeed = -10;

    }

}
