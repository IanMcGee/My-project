using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float bulletDamage;
    [SerializeField] private GameObject bulletHole;
    
    void Update()
    {
       this.transform.Translate(this.transform.up * (Time.deltaTime * bulletSpeed));
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject hole = Instantiate(bulletHole, this.transform);
        if (other.GetComponent<Target>())
        {
            Target hit = other.GetComponent<Target>();
            hit.Damage(bulletDamage);
        }
        
        Destroy(this);
    }
}