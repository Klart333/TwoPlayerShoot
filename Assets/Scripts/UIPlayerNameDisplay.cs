using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
public class UIPlayerNameDisplay : MonoBehaviour
{
    private void Start()
    {
        print(PhotonNetwork.LocalPlayer.NickName);
        if (PhotonNetwork.LocalPlayer.NickName != "")
        {
            GetComponent<TextMeshProUGUI>().text = PhotonNetwork.LocalPlayer.NickName;
        }
    }
}
