using UnityEngine;

public class WinningCinematicCamera : MonoBehaviour
{
    [SerializeField] GameObject CineCam;
    [SerializeField] GameObject VirtualCam1, VirtualCam2;
    void Update()
    {
        if (GameManager.Instance.isFinished)
        {
            CineCam.SetActive(true);
            Invoke("activecam1", 0.5f);
        }
    }
    void activecam1()
    {
        VirtualCam1.SetActive(true);
        
        VirtualCam2.SetActive(false);
    }
}
