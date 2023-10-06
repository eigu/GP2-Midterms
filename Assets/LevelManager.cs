using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public GameObject player;

    public GameObject gameOverScreen;

    void Awake()
    {
        Time.timeScale = 1;
    }

    public void Update()
    {
        if (!player)
        {
            Time.timeScale = 0;
            gameOverScreen.SetActive(true);
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Game");
    } 
}