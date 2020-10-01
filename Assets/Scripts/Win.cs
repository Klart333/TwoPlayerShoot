using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Photon.Pun;
public class Win : MonoBehaviour
{
    public static Win Instance;

    public PhotonView photonView;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            //DontDestroyOnLoad(this.gameObject);

            photonView = PhotonView.Get(this);
        }
    }
    
    [PunRPC]
    public void OnWin(GameObject player)
    {
        GameObject winPanel = (GameObject)Instantiate(Resources.Load("WinPanel"), GameObject.Find("Canvas").transform);
        TextMeshProUGUI Wintext = winPanel.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        if (player.GetComponent<Gubbe2>())
        {
            Wintext.text = "Player 1 Wins!";
        }
        else if (player.GetComponent<Gubbe1>())
        {
            Wintext.text = "Player 2 Wins!";
        }
    }

    [PunRPC]
    public void RestartGame()
    {
        PhotonNetwork.LoadLevel(1);
    }
}
