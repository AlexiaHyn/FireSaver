using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBurnOut : MonoBehaviour
{
    public Vector3 scaleReduction = new Vector3(0.1f, 0.1f, 0.1f); // The amount by which the scale is reduced on each hit

    // This method is called when the GameObject collides with another GameObject
    void OnCollisionEnter(Collision collision)
    {
        // Reduce the scale of the GameObject
        transform.localScale -= scaleReduction;

        // Optional: Destroy the GameObject if its scale gets too small
        if (transform.localScale.x <= 0 || transform.localScale.y <= 0 || transform.localScale.z <= 0)
        {
            Destroy(gameObject);
        }
    }
}
