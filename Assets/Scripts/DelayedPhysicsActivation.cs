using UnityEngine;
using System.Collections;

public class DelayedPhysicsActivation : MonoBehaviour
{
    public float delay = 2f; // Delay in seconds

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true; // Disable physics
            StartCoroutine(EnablePhysicsAfterDelay());
        }
    }

    IEnumerator EnablePhysicsAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        rb.isKinematic = false; // Enable physics
    }
}