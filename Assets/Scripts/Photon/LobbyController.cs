using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System;

public class LobbyController : MonoBehaviourPunCallbacks
{
    public int roomSize;

    public void JoinRoom()
    {
        PhotonNetwork.JoinRandomRoom();
        print("Trying to join");
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        print("Couldn't find Room, Creating one instead");
        CreateRoom();
    }

    private void CreateRoom()
    {
        print("Creating Room");
        int randomRoomNumber = UnityEngine.Random.Range(0, 1000000);
        print("Random Room Number: " + randomRoomNumber);

        RoomOptions options = new RoomOptions()
        {
            IsVisible = true,
            IsOpen = true,
            MaxPlayers = (byte)roomSize
        };

        PhotonNetwork.CreateRoom("Room" + randomRoomNumber, options); 
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        print("Trying Again");
        CreateRoom();
    }

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }
}

