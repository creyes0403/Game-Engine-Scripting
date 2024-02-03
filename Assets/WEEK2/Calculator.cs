using TMPro;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    // To see result on screen (label)
    public TextMeshProUGUI label;

    public float prevInput;

    public bool clearPrevInput;

    private EquationType equationType;
    private void Start()
    {
        Clear();
    }
    public void AddInput(string input)
    {
        if (clearPrevInput == true) { label.text = string.Empty; clearPrevInput = false;};
        label.text += input;
    }

    public void SetEquationAsAdd()
    {
        prevInput = float.Parse(label.text);
        clearPrevInput = true;
        equationType = EquationType.ADD;
    }

    public void SetEquationAsSubstract()
    {
        prevInput = float.Parse(label.text);
        clearPrevInput = true;
        equationType = EquationType.SUBTRACT;
    }

    public void SetEquationAsMultiply()
    {
        prevInput = float.Parse(label.text);
        clearPrevInput = true;
        equationType = EquationType.MULTIPLY;
    }

    public void SetEquationAsDivide()
    {
        prevInput = float.Parse(label.text);
        clearPrevInput = true;
        equationType = EquationType.DIVIDE;
    }

    public void Add()
    {
        float value = prevInput + float.Parse(label.text);
        label.text = value.ToString();
    }

    public void Substract()
    {
        float value = prevInput - float.Parse(label.text);
        label.text = value.ToString();
    }

    public void Multiply()
    {
        float value = prevInput * float.Parse(label.text);
        label.text = value.ToString();
    }

    public void Divide()
    {
        float value = prevInput / float.Parse(label.text);
        label.text = value.ToString();
    }

    //To reset the screen after creating an equation
    public void Clear()
    {
        label.text = "0";
        clearPrevInput = true;
        prevInput = 0;
   
    equationType = EquationType.None;
    }
    public void Calculate()
    {
        //To see the equation after selecting =
        if (equationType == EquationType.ADD) Add();
        else if (equationType == EquationType.SUBTRACT) Substract();
        else if (equationType == EquationType.MULTIPLY) Multiply();
        else if (equationType == EquationType.DIVIDE) Divide();
    }
    public enum EquationType
    {
        None = 0,
        ADD = 1,
        SUBTRACT = 2,
        MULTIPLY = 3,
        DIVIDE = 4
    }
}

