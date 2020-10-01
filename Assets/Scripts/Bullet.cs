using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float timer;
    float timerMax = 10;
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timerMax)
        {
            Destroy(gameObject);
        }
    }
}
