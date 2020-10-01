using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class NetworkController : MonoBehaviourPunCallbacks
{
    [SerializeField]
    Button button;
    [SerializeField]
    InputField nameField;

    private void Start()
    {
        button.interactable = false;
        PhotonNetwork.ConnectUsingSettings();
        print("Connecting...");
    }

    public override void OnConnectedToMaster()
    {
        print("Connected to " + PhotonNetwork.CloudRegion);
        button.interactable = true;
        PhotonNetwork.AutomaticallySyncScene = true;
    }

    public void SetUserName()
    {
        PhotonNetwork.LocalPlayer.NickName = nameField.text;
    }
}
