using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public List<GameObject> enemyColor;
    public GameObject enemy;
    public float enemySpeed;
    public Transform targetPlayer;


    void Awake()
    {
        enemy = enemyColor[Random.Range(0, enemyColor.Count)];
        enemy.SetActive(true);
    }

    void Update()
    {
        var step = enemySpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position,
        targetPlayer.position, step);

        if (Vector3.Distance(transform.position, targetPlayer.position) < 0.001f)
        {
        targetPlayer.position *= -1.0f;
        }
    }
}
