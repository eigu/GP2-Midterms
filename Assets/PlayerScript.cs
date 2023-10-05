using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public List<GameObject> playerColor;
    public GameObject player;
    public int playerColorCount = 0;
    public Transform target;
    public float range = 30f;

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

        Vector3 relativePos = target.position - transform.position; 
        if (relativePos.magnitude < range)
        {
            transform.rotation = Quaternion.LookRotation(relativePos, Vector3.up);
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

    private void OnDrawGizmos()
    {
        float radius = range;

        float angleStep = 360f / 360;

        Gizmos.color = Color.white;
        for (int i = 0; i < 360; i++)
        {
            float angle = i * angleStep;

            Vector3 position = transform.position + radius * Vector3.right * Mathf.Cos(angle) + radius * Vector3.forward * Mathf.Sin(angle);

            Gizmos.DrawLine(position, position + Vector3.right * 0.1f);
        }
    }
}