using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomPinCollider : MonoBehaviour
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
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(12, 3);
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(13, 25);
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(14, 45);
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(15, 25);
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(16, 3);

            EnableDesableObject(false);
            Debug.Log(other.gameObject.name);
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
