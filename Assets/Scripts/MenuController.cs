using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private Button newGameButton;
    [SerializeField] private Button joinGameButton;
    [SerializeField] private Slider seedSlider;
    [SerializeField] private Text seedText;

    private void Start()
    {
        newGameButton.onClick.AddListener(OnNewGameClick);
        joinGameButton.onClick.AddListener(OnJoinGameClick);
        seedSlider.onValueChanged.AddListener(OnSeedSliderChanged);
    }

    private void OnNewGameClick()
    {
        PlayerPrefs.SetInt("Seed", (int)seedSlider.value);
        // NetworkManager.Singleton.StartHost();
        SceneManager.LoadScene("Game");
    }

    private void OnJoinGameClick()
    {
        // NetworkManager.Singleton.StartClient();
    }

    private void OnSeedSliderChanged(float value)
    {
        int seed = (int)value;
        seedText.text = seed.ToString();
    }

    private void OnDestroy()
    {
        // if (newGameButton != null)
        //     newGameButton.onClick.RemoveListener(OnNewGameClick);
        // if (joinGameButton != null)
        //     joinGameButton.onClick.RemoveListener(OnJoinGameClick);
    }
}
