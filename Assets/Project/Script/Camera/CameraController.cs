using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{ 
    [SerializeField] Vector3 initialPosition;
    [SerializeField] Vector3 maxPosition;
    [SerializeField]
    [Range(0, 1)] private float progress;

    private void Awake()
    {
        transform.localPosition = initialPosition;

    }
    private void LateUpdate()
    {
        transform.localPosition = Vector3.Lerp(initialPosition, transform.localPosition + maxPosition, progress);
    }
}
