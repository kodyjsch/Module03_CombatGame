using UnityEngine;

public class TargetHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("sword"))
        {
            Destroy(gameObject);
        }
    }
}
