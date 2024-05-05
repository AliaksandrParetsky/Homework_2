using UnityEngine;

public class ControllerWindows : MonoBehaviour
{
    public void OnOpen()
    {
        gameObject.SetActive(true);
    }

    public void OnClose()
    {
        gameObject.SetActive(false);
    }
}
