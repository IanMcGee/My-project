using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 1f;
    

    public void Damage(float damage)
    {
        health = health - damage;
        if (health <= 0)
        {
           this.GetComponent<Animator>().Play("TargetFall");
        }
    }
}
