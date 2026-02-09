using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Renderer rend;
    public Color flashColor = Color.red;
    public float flashDuration = .2f;

    private Color originalColor;

    private void Start()
    {
        originalColor = rend.material.color;
    }

    IEnumerator flash()
    {
        rend.material.color = flashColor;
        yield return new WaitForSeconds(flashDuration);
        rend.material.color = originalColor;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) { 
            StartCoroutine(flash());
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        Debug.Log("collided");
        if (other.gameObject.CompareTag("sword"))
        {
            Debug.Log("sword");
            StartCoroutine(flash());
        }
    }

}
