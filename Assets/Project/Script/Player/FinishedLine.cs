using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedLine : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] GameObject confegitee;
    [SerializeField] GameObject Podium;
    [SerializeField] GameObject camController;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.forwarSpeed = 0;
            player.leftRightSpeed = 0;
            GameObject parentOfPalyer = other.gameObject.transform.parent.gameObject;
            parentOfPalyer.transform.SetParent(Podium.transform);
            parentOfPalyer.transform.localPosition = new Vector3(0,0f,0);
           // camController.transform.position = new Vector3(0, 6f, 139);
            //camController.transform.rotation =  Quaternion.Euler(13f, 0, 0);
            //Instantiate(playe)
            confegitee.SetActive(true);
            GameManager.Instance.isFinished = true;
        }
    }
}
