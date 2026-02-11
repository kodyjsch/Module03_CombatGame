using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Renderer rend;
    public Color flashColor = Color.red;
    public float flashDuration = .5f;
    private Color originalColor;

    public float damage = 1;
    private healthManager hM;

    public AudioSource SFX;

    public bool doesDamage = true;

    private void Start()
    {
        originalColor = rend.material.color;
        hM = GetComponentInParent<healthManager>();
    }

    IEnumerator flash()
    {
        rend.material.color = flashColor;
        yield return new WaitForSeconds(flashDuration);
        rend.material.color = originalColor;
    }

    void OnTriggerEnter(Collider other) 
    {
        Debug.Log("collided");
        if (other.gameObject.CompareTag("sword"))
        {
            SFX.Play();

            if(doesDamage == true)
            {
                StartCoroutine(flash());
                hM.takeDamage(damage);

                DamageNumber.current.CreatePopUp(transform.position, damage.ToString());
            }
        }
    }

}
