using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Code found from Gabriel Aguiar Prod.: 'Unity 2018 - Game VFX - Shatter / Destroy / Explode Objects Tutorial' accessed December 19th 2022 (https://www.youtube.com/watch?v=w4aMtKeD2w4&ab_channel=GabrielAguiarProd.)
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
        foreach(Transform t in transform)
        {
            var rb = t.GetComponent<Rigidbody>();
            rb.isKinematic = false;

            if(rb != null)
            {
                rb.AddExplosionForce(Random.Range(minForce, maxForce), transform.position, radius);
                
                if(t.gameObject.name.Contains("pot"))
                {
                    FindObjectOfType<AudioManager>().Play("Pot Break");
                }
                else
                {
                    FindObjectOfType<AudioManager>().Play("Barrel Break");
                }
            }
        }
    }
}
