using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthManager : MonoBehaviour
{
 
    public float health = 8.0f;
    private float startHealth;

    public Animator deathAnim;

    private void Start()
    {
        startHealth = health;
    }

    public void takeDamage(float dmg)
    {
        health = health - dmg;

        if(health < 1)
        {
            Died();
        }
    }

    IEnumerator Died()
    {
        deathAnim.SetTrigger("die");
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

}
