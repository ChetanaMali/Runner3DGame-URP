using Unity.VisualScripting;
using UnityEngine;

public class TopPinCollider : MonoBehaviour
{
    public float zoomScale = 0.2f; // The scale to zoom to
    public float zoomSpeed = 1f; // Speed of the zoom animation

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            EnableDesableObject(true);
            other.gameObject.transform.localScale = other.gameObject.transform.localScale +  new Vector3(2,2,2); 
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
            other.gameObject.transform.localScale = other.gameObject.transform.localScale - new Vector3(2, 2, 2);
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
