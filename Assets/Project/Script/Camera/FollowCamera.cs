
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float smoothSpeed = 1;
    Vector3 offset;

    
    private void Awake()
    {
        offset = transform.position - target.position;
    }
    private void LateUpdate()
    {
        transform.position = target.position + offset;
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, target.position.x, smoothSpeed), transform.position.y, target.position.z + offset.z);
        if (GameManager.Instance.isFinished)
        {
            transform.position = new Vector3(0, 6, 139);
            transform.rotation = Quaternion.Euler(13f, 0, 0);
        }
        
    }
}
