using Unity.VisualScripting;
using UnityEngine;

public class TopPinCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EnableDesableObject(true);
            //other.gameObject.transform.localScale = other.gameObject.transform.localScale +  new Vector3(2,2,2);
            isPopup = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(0, 7);
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(1, 30);
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(2, 50);
            other.GetComponent<SkinnedMeshRenderer>().SetBlendShapeWeight(3, 30);

            EnableDesableObject(false);
            //other.gameObject.transform.localScale = other.gameObject.transform.localScale - new Vector3(2, 2, 2);
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
}
