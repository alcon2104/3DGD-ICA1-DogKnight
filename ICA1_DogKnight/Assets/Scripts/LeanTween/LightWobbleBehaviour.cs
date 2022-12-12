using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightWobbleBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject light;

    void Start()
    {
        LeanTween.scale(light, Vector3.one * 1.5f, 0.5f).setLoopPingPong().setEase(LeanTweenType.easeInOutBack);
    }
}
