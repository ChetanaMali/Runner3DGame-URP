using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashAddScripts : MonoBehaviour
{
    [SerializeField] int price;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.money += price;
            GameManager.Instance.moneyText.text = GameManager.Instance.money.ToString();
        }
    }
    
}
