using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaseSkinBlendShape : MonoBehaviour
{
    [SerializeField] GameObject vase;
    private void Update()
    {
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(0, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(0));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(1, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(1));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(2, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(2));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(3, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(3));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(4, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(4));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(5, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(5));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(6, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(6));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(7, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(7));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(8, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(8));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(9, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(9));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(10, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(10));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(11, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(11));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(12, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(12));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(13, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(13));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(14, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(14));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(15, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(15));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(16, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(16));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(17, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(17));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(18, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(18));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(19, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(19));
        this.gameObject.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(20, vase.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(20));
    }
}
