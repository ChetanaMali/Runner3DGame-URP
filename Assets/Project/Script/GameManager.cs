using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region SINGLETON INSTANCE CODE
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    #endregion

    public int money;
    public TMP_Text moneyText;

    public bool isFinished;
}
