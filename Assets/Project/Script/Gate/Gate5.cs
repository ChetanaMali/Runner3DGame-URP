using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate5 : MonoBehaviour
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
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(0) < 61.8f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(0, 61.8f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(1) < 59.4f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(1, 59.4f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(2) < 56.8f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(2, 56.8f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(3) < 54f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(3, 54f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(4) < 51.8f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(4, 51.8f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(5) < 49.7)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(5, 49.7f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(6) < 48.1f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(6, 48.1f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(7) < 48.2f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(7, 48.2f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(8) < 51.1f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(8, 51.1f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(9) < 56.5f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(9, 56.5f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(10) < 66.3f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(10, 66.3f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(11) < 78f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(11, 78f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(12) < 88.9f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(12, 88.9f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(13) < 93.5f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(13, 93.5f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(14) < 94.6f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(14, 94.6f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(15) < 94.3f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(15, 94.3f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(16) < 93.9f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(16, 93.9f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(17) < 94.3f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(17, 94.3f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(18) < 91.8f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(18, 91.8f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(19) < 60.5f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(19, 60.5f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(20) < 49.9f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(20, 49.9f);
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
