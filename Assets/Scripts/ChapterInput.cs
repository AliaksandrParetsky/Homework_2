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
            Debug.LogError("��������� TMP_Text �� ������!");
        }
    }

    private void OnDisable()
    {
        textInputField.text = null;
    }
}
