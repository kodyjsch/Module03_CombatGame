using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManager : MonoBehaviour
{
 
    public float health = 8.0f;
    private float startHealth;

    public Animator deathAnim;

    public ParticleSystem boom;
    public ParticleSystem debris;


    private void Start()
    {
        startHealth = health;

    }

    public void takeDamage(float dmg)
    {
        health = health - dmg;

        if(health < 1)
        {
            deathAnim.SetTrigger("die");
            var colliders = GetComponentsInChildren<Collider>();
            foreach (var collider in colliders)
            {
                collider.enabled = false;
            }

            Invoke("BlowUp", 2.0f);
        }
    }

    public void BlowUp()
    {
        boom.Play();
        debris.Play();
        Destroy(gameObject);
    }

}
