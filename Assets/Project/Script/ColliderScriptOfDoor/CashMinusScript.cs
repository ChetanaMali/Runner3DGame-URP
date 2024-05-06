
using UnityEngine;

public class CashMinusScript : MonoBehaviour
{
    [SerializeField] int price;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.Instance.money -= price;
            GameManager.Instance.moneyText.text = GameManager.Instance.money.ToString();
        }
    }
    
}
