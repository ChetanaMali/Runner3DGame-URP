using UnityEngine;

public class Gate4 : MonoBehaviour
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
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(0) < 82.6)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(0, 82.6f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(1) < 82.6f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(1, 82.6f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(2) < 58.4f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(2, 58.4f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(3) < 41.6f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(3, 41.6f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(4) < 30.2f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(4, 30.2f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(5) < 23.5f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(5, 23.5f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(6) < 19.4f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(6, 19.4f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(7) < 17.3f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(7, 17.3f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(8) < 16.2f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(8, 16.2f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(9) < 17f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(9, 17f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(10) < 17.3f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(10, 17.3f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(11) < 18.6f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(11, 18.6f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(12) < 21.5f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(12, 21.5f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(13) < 22.9f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(13, 22.9f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(14) < 27.3f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(14, 27.3f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(15) < 31.6f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(15, 31.6f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(16) < 36.9f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(16, 36.9f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(17) < 40.6f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(17, 40.6f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(18) < 46.9f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(18, 46.9f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(19) < 52.6f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(19, 52.6f);
            }
            if (other.GetComponent<SkinnedMeshRenderer>().GetBlendShapeWeight(20) < 59.1f)
            {
                other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(20, 59.1f);
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
