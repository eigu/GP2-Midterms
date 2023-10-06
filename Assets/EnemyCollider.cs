using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Red") && CompareTag("Red") || other.CompareTag("Green") && CompareTag("Green") || other.CompareTag("Blue") && CompareTag("Blue"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Player"))
        {
            return;
        }
        else
        {
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
