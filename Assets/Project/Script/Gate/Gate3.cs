using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPopup = true;
            EnableDesableObject(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EnableDesableObject(false);
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(0) < 73.1f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(0, 73.1f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(1) < 73.5f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(1, 73.5f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(2) < 77.1f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(2, 77.1f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(3) < 84.8f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(3, 84.8f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(4) < 85.6f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(4, 85.6f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(5) < 85.9f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(5, 85.9f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(6) < 84.3f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(6, 84.3f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(7) < 77.3f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(7, 77.3f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(8) < 61.1f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(8, 61.1f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(9) < 53.2f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(9, 53.2f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(10) < 49.9f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(10, 49.9f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(11) < 48.2f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(11, 48.2f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(12) < 49.4f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(12, 49.4f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(13) < 52.4f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(13, 52.4f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(14) < 55.7f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(14, 55.7f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(15) < 61.1f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(15, 61.1f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(16) < 66.5f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(16, 66.5f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(17) < 71.7f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(17, 71.7f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(18) < 76f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(18, 76f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(19) < 77.3f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(19, 77.3f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(20) < 64.8f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(20, 64.8f);
            }

        }
    }

    public bool big, small, isscaledUp, isPopup;
    [SerializeField] GameObject player;
    private void Update()
    {
        // GameManager.Instance.PopUpAnimation(isPopup);
        if (isPopup)
        {
            if (player.transform.localScale.x <= 1)
            {
                big = true;
                small = false;

            }
            if (player.transform.localScale.x >= 1.1f)
            {
                small = true;
                big = false;

            }
            if (!isscaledUp)
            {
                if (small)
                {
                    player.transform.localScale = new Vector3(1, 1, 1);
                }
                if (big)
                {
                    player.transform.localScale += new Vector3(1f, 1f, 1f) * Time.deltaTime;
                }
            }

            if (player.transform.localScale.x == 1)
            {
                isscaledUp = true;
                isPopup = false;
            }
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
