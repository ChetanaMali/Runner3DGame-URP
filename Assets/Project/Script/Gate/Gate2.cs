using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate2 : MonoBehaviour
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
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(1) < 61.8f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(1, 61.8f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(2) < 83.8f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(2, 83.8f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(3) < 86.4f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(3, 86.4f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(4) < 86.7f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(4, 86.7f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(5) < 81.3f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(5, 81.3f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(6) < 71.8f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(6, 71.8f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(7) < 68.4f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(7, 68.4f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(8) < 66.5f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(8, 66.5f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(9) < 59.4f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(9, 59.4f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(10) < 44.3f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(10, 44.3f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(11) < 36.9f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(11, 36.9f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(12) < 31.8f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(12, 31.8f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(13) < 29.1f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(13, 29.1f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(14) < 28.1f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(14, 28.1f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(15) < 29.1f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(15, 29.1f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(16) < 33.2f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(16, 33.2f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(17) < 39.3f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(17, 39.3f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(18) < 49f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(18, 49f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(19) < 57.2f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(19, 57.2f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(20) < 54.9f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(20, 54.9f);
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
