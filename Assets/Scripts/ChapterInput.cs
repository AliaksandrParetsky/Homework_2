using TMPro;
using UnityEngine;

public class ChapterInput : MonoBehaviour
{
    private TMP_InputField textInputField;
    void OnEnable()
    {
        if (GetComponent<TMP_InputField>())
        {
            if(textInputField != null)
            {
                textInputField = GetComponent<TMP_InputField>();
            }
        }
    }

    private void OnDisable()
    {
        textInputField.text = null;
    }
}
