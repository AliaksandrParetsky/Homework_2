using TMPro;
using UnityEngine;

public class DropDowne : MonoBehaviour
{
    [SerializeField] private TMP_Text text;

    public void DropdownSample(int index)
    {
        switch (index)
        {
            case 0: text.text = "Option A";
                break;
            case 1: text.text = "Option B";
                break;
            case 2: text.text = "Option C";
                break;
            case 3: text.text = "Option D";
                break;
                    
        }
    }
}
