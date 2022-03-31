using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public Color selectColor;
    private Color normalColor;
    public Button button;
    private Image btnImage;
    
    void Awake()
    {
        btnImage = GetComponent<Image>();
        button = GetComponent<Button>();
        normalColor = btnImage.color;
    }

    public void SelectButton()
    {
        btnImage.color = selectColor;
        button.onClick.Invoke();
    }

    public void DeselectButton()
    {
        btnImage.color = normalColor;
    }
}
