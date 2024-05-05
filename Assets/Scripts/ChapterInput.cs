using TMPro;
using UnityEngine;

public class ChapterInput : MonoBehaviour
{
    private TMP_InputField textInputField;
    void OnEnable()
    {
        if (GetComponent<TMP_InputField>())
        {
            textInputField = GetComponent<TMP_InputField>();
        }
        else
        {
            Debug.LogError("Компонент TMP_Text не найден!");
        }
    }

    private void OnDisable()
    {
        textInputField.text = null;
    }
}
