using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Win : MonoBehaviour
{
    public static Win Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    
    public void OnWin(GameObject player)
    {
        Time.timeScale = 0;
        GameObject winPanel = (GameObject)Instantiate(Resources.Load("WinPanel"), GameObject.Find("Canvas").transform);
        TextMeshProUGUI Wintext = winPanel.transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        if (player.name == "Gubbe2")
        {
            Wintext.text = "Player 1 Wins!";
        }
        else if (player.name == "Gubbe1")
        {
            Wintext.text = "Player 2 Wins!";
        }
    }

    public void ResartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
