using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;

    public Vector3 offset;
    public Vector3 eulerRotation;
    public float maxRadiansDelta;
    public float maxMagnitudeDelta;
    public float damper;
    void Start()
    {
        transform.eulerAngles = eulerRotation;
    }

    void Update()
    {
        if (Target == null) return;

        transform.position = Vector3.Lerp(transform.position, Target.position + offset, damper * Time.deltaTime);
        transform.eulerAngles = Vector3.RotateTowards(eulerRotation, Target.eulerAngles, maxRadiansDelta, maxMagnitudeDelta);
    }
}
