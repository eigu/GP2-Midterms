using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public List<GameObject> playerColor;
    public GameObject player;
    public int playerColorCount = 0;

    void Awake()
    {
        player = playerColor[playerColorCount++];
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ChangePlayerColor();
        }
    }

    public void ChangePlayerColor()
    {
        player.SetActive(false);
        player = playerColor[playerColorCount++];
        if (playerColorCount == playerColor.Count)
        {
            playerColorCount = 0;
        }

        player.SetActive(true);
    }
}
