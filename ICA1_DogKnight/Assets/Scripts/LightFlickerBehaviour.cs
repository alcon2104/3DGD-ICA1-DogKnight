using System.Collections;
using UnityEngine;

public class LightFlickerBehaviour : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Minimum random light intensity")]
    private bool flickering;

    [SerializeField]
    [Range(0, 10)]
    [Tooltip("Min random light intensity")]
    private float intensityMin = 5;

    [SerializeField]
    [Range(0.1f, 20)]
    [Tooltip("Max random light intensity")]
    private float intensityMax = 10;

    [SerializeField]
    [Range(0.2f, 10)]
    [Tooltip("Min time delay between flicker")]
    private float minTimeDelaySecs = 1;

    [SerializeField]
    [Range(0.2f, 10)]
    [Tooltip("Max time delay between flicker")]
    private float maxTimeDelaySecs = 5;

    private float timeDelaySecs;
    private Light light;

    private void Awake()
    {
        light = gameObject.GetComponent<Light>();
    }

    private void Update()
    {
        if (flickering)
            StartCoroutine(Flicker());
    }

    private IEnumerator Flicker()
    {
        //turn off light
        //set intensity to min
        light.intensity = intensityMin;

        //wait for a random amount in secs
        timeDelaySecs = Random.Range(minTimeDelaySecs, maxTimeDelaySecs);
        yield return new WaitForSeconds(timeDelaySecs);

        //turn the light back on
        light.intensity = intensityMax;
        light.enabled = true;

        //wait for a random amount in secs
        timeDelaySecs = Random.Range(minTimeDelaySecs, maxTimeDelaySecs);
        yield return new WaitForSeconds(timeDelaySecs);
    }
}