using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakObjectBehaviour : MonoBehaviour
{
    [SerializeField]
    public float minForce;
    [SerializeField]
    public float maxForce;
    [SerializeField]
    public float radius;

    public void Break()
    {
        if(gameObject)
        foreach(Transform t in transform)
        {
            var rb = t.GetComponent<Rigidbody>();

            if(rb != null)
            {
                rb.AddExplosionForce(Random.Range(minForce, maxForce), transform.position, radius);
            }
        }
    }
}
