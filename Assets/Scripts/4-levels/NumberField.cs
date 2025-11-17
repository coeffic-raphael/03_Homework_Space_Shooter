using TMPro;
using UnityEngine;

/**
 * This component should be attached to a TextMeshPro object.
 * It allows to feed an integer number to the text field.
 */
[RequireComponent(typeof(TMP_Text))]
public class NumberField : MonoBehaviour
{
    private int number;
    private TMP_Text text;
    public int GetNumber()
    {
        return this.number;
    }

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    public void SetNumber(int newNumber)
    {
        this.number = newNumber;
        if (text != null)
        {
            text.text = newNumber.ToString();
        }
    }

    public void AddNumber(int toAdd)
    {
        SetNumber(this.number + toAdd);
    }
}
