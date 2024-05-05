using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ChapterButtonsController : MonoBehaviour
{
    [SerializeField] private TMP_Text lableText;

    private Button button;

    private void GetInfo()
    {
        lableText.text = $"The first way to click on {gameObject.name} using a script";
    }

    private void OnEnable()
    {
        if (GetComponent<Button>() != null)
        {
            button = GetComponent<Button>();
            button.onClick.AddListener(GetInfo);

            if(lableText != null)
            {
                lableText.text = "Buttons";
            }
            else
            {
                Debug.LogError("LableText is Null!");
                return;
            }
        }
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(GetInfo);
    }
}
