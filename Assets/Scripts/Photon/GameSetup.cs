using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using System.IO;
using System;

public class GameSetup : MonoBehaviour
{
    private void Start()
    {
        CreatePlayer();
    }

    private void CreatePlayer()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.Instantiate(Path.Combine("Prefabs", "Gubbe1"), new Vector3(-5, 0, 0), Quaternion.identity);
        }
        else
        {
            PhotonNetwork.Instantiate(Path.Combine("Prefabs", "Gubbe2"), new Vector3(5, 0, 0), Quaternion.identity);
        }
    }
}
