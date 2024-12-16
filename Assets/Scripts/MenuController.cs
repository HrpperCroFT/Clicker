using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Button newGameButton;
    [SerializeField] private Button joinGameButton;

    private void Start()
    {
        newGameButton.onClick.AddListener(OnNewGameClick);
        joinGameButton.onClick.AddListener(OnJoinGameClick);
    }

    private void OnNewGameClick()
    {
        // NetworkManager.Singleton.StartHost();
        SceneManager.LoadScene("Game");
    }

    private void OnJoinGameClick()
    {
        // NetworkManager.Singleton.StartClient();
    }

    private void OnDestroy()
    {
        // if (newGameButton != null)
        //     newGameButton.onClick.RemoveListener(OnNewGameClick);
        // if (joinGameButton != null)
        //     joinGameButton.onClick.RemoveListener(OnJoinGameClick);
    }
}
