using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    //Joysticks
    [SerializeField] Joystick joystick;

    public float forwarSpeed;
    public float leftRightSpeed;
    [SerializeField] Vector2 minMaxX;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if(!GameManager.Instance.isFinished)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minMaxX.x, minMaxX.y), transform.position.y, transform.position.z);
            rb.velocity = new Vector3(joystick.Horizontal * leftRightSpeed * Time.deltaTime, rb.velocity.y, forwarSpeed * Time.deltaTime);
        }
        
    }
}
