using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    [SerializeField] private GameObject bulletHole;
    
    void Update()
    {
       this.transform.Translate(this.transform.up * (Time.deltaTime * bulletSpeed));
    }

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(bulletHole, this.transform);
        Destroy(this);
    }
}
