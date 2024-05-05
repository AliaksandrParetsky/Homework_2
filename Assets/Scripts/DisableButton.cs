using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisableButton : MonoBehaviour
{
    private Button button;

    [SerializeField] private List<Button> buttons;


    private void Awake()
    {
        if (GetComponent<Button>())
        {
            button = GetComponent<Button>();
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
        button.onClick.AddListener(DisButtons);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(DisButtons);

        foreach (var button in buttons)
        {
            button.interactable = true;
        }
    }
}
