using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coloring : MonoBehaviour
{
    public Color[] colorList;
    public int colorCount;
    public GameObject coloring_Brush;
    public GameObject coloring_Brush_Lit;
    public Image coloringBrush;
    public Button[] coloring_Buttons;
    public GameObject coloring_FinishPanel;
    public AudioSource sounds;
    public void PaintButton(int colorCode)
    {
        colorCount = colorCode;
    }
    public void ChangeBrushColor()
    {
        if (colorCount == 0)
        {
            coloring_Brush.GetComponent<Image>().color = new Color32(0, 84, 255, 255);
            coloring_Brush_Lit.GetComponent<Image>().color = new Color32(0, 84, 255, 255);
        }
        else if (colorCount == 1)
        {
            coloring_Brush.GetComponent<Image>().color = new Color32(255, 222, 0, 255);
            coloring_Brush_Lit.GetComponent<Image>().color = new Color32(255, 222, 0, 255);
        }
        else if (colorCount == 2)
        {
            coloring_Brush.GetComponent<Image>().color = new Color32(144, 0, 255, 255);
            coloring_Brush_Lit.GetComponent<Image>().color = new Color32(144, 0, 255, 255);
        }
        else if (colorCount == 3)
        {
            coloring_Brush.GetComponent<Image>().color = new Color32(15, 167, 11, 255);
            coloring_Brush_Lit.GetComponent<Image>().color = new Color32(15, 167, 11, 255);
        }
        else if (colorCount == 4)
        {
            coloring_Brush.GetComponent<Image>().color = new Color32(255, 125, 0, 255);
            coloring_Brush_Lit.GetComponent<Image>().color = new Color32(255, 125, 0, 255);
        }
        else if (colorCount == 5)
        {
            coloring_Brush.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
            coloring_Brush_Lit.GetComponent<Image>().color = new Color32(0, 0, 0, 255);
        }
        else if (colorCount == 6)
        {
            coloring_Brush.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
            coloring_Brush_Lit.GetComponent<Image>().color = new Color32(255, 0, 0, 255);
        }
        else if (colorCount == 7)
        {
            coloring_Brush.GetComponent<Image>().color = new Color32(255, 221, 188, 255);
            coloring_Brush_Lit.GetComponent<Image>().color = new Color32(255, 221, 188, 255);
        }
        else
        {
            coloring_Brush.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            coloring_Brush_Lit.GetComponent<Image>().color = new Color32(255, 255, 255, 255);
        }
    }
    void Start()
    {
        ChangeBrushColor();
    }
    public void ChangeImgColor()
    {
        for (int i = 0; i < coloring_Buttons.Length; i++)
        {
            int index = i; // closure variable
            coloring_Buttons[i].onClick.AddListener(() => ChangeColor(index));
        }
    }
    public void ChangeColor(int buttonIndex)
    {
            coloring_Buttons[buttonIndex].image.color = coloringBrush.color;
    }
    public void FinishPanel()
    {
        sounds.Play();
        coloring_FinishPanel.SetActive(true);
    }
    public void ResetColoring()
    {
        colorCount = 0;
        ChangeBrushColor();

        for (int i = 0; i < coloring_Buttons.Length; i++)
        {
            coloring_Buttons[i].image.color = Color.white;
        }
        coloring_Brush.GetComponent<Image>().color = Color.white;
        coloring_Brush_Lit.GetComponent<Image>().color = Color.white;
        coloring_FinishPanel.SetActive(false);
    }
    public void ResetColoringChildren()
    {
        colorCount = 0;
        ChangeBrushColor();

        for (int i = 0; i < coloring_Buttons.Length; i++)
        {
            coloring_Buttons[i].image.color = Color.white;
        }
        coloring_Brush.GetComponent<Image>().color = Color.white;
        coloring_Brush_Lit.GetComponent<Image>().color = Color.white;
        coloring_Buttons[11].GetComponent<Image>().color = new Color32(153, 0, 181, 255);
        coloring_Buttons[10].image.color = Color.blue;
        coloring_FinishPanel.SetActive(false);
    }
}
