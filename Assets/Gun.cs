using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private AudioClip shootSound;
    [SerializeField] private AudioSource sound;
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject bulletMaker;
    [SerializeField] private ParticleSystem muzzleFlash;
    public float damage = 1f;

    public void Shoot()
    {
        sound.PlayOneShot(shootSound);
        muzzleFlash.Play(); 
        GameObject spawnedBullet = Instantiate(bullet, bulletMaker.transform.position,bulletMaker.transform.rotation);
        spawnedBullet.GetComponent<bullet>().bulletDamage = damage;
    }
}
