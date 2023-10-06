using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float bulletDecay = 4f;

    void Start()
    {
        Destroy(gameObject, bulletDecay);
    }
}
