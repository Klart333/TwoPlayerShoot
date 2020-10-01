using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AganeScript : MonoBehaviour
{
    public void OnButton()
    {
        Win.Instance.ResartGame();
    }
}
