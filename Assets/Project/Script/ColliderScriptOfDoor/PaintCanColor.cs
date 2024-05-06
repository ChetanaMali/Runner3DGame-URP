using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCanColor : MonoBehaviour
{
    [SerializeField] Material canColorMat;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<Renderer>().material = canColorMat;
            Destroy(gameObject);
        }
    }
}
