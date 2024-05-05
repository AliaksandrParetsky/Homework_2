using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class DisableButton : MonoBehaviour
{
    private Button disableButton;

    [SerializeField] private List<Button> buttons;


    private void Awake()
    {
        if (GetComponent<Button>())
        {
            disableButton = GetComponent<Button>();
        }
        else
        {
            Debug.LogError("Component Button is Null!");
            return;
        }
    }

    private void DisButtons()
    {
        foreach (var button in buttons)
        {
            button.interactable = false;
        }
    }

    private void OnEnable()
    {
        disableButton.onClick.AddListener(DisButtons);
    }

    private void OnDisable()
    {
        disableButton.onClick.RemoveListener(DisButtons);

        foreach (var button in buttons)
        {
            button.interactable = true;
        }
    }
}
