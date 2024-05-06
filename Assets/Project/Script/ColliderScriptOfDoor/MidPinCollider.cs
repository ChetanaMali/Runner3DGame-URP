using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidPinCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EnableDesableObject(true);
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(7, 18);
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(8, 40);
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(9, 40);
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(10, 18);

            EnableDesableObject(false);
        }

    }
    void EnableDesableObject(bool setActive)
    {
        int cc = this.gameObject.transform.parent.childCount;
        for (int i = 0; i < cc; i++)
        {
            GameObject childGo = this.gameObject.transform.parent.GetChild(i).gameObject;
            if (childGo.gameObject.name == "ParticleSystem")
            {
                childGo.gameObject.SetActive(setActive);
            }
        }
    }
}
