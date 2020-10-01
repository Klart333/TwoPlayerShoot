using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class AganeScript : MonoBehaviour
{
    public void OnButton()
    {
        Win.Instance.photonView.RPC("RestartGame", RpcTarget.All);
    }
}
