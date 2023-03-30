using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Coloring_Mosque : MonoBehaviour
{
    public Color[] colorListMosque;
    public int colorCountMos;
    public GameObject coloring_Brush_Mos, coloring_Brush_Mos_Lit, coloring_FinishPanel;
    public Image coloringBrushMosque;
    public Button[] coloring_Buttons_Mosque;
    public Color currentColor;
    public GameObject coloringMos_FinishPanel;
    public AudioSource sounds;
    private void Start()
    {
        currentColor = Color.white;
    }
    public void ChangeBrushColorMosque()
    {
        coloring_Brush_Mos.GetComponent<Image>().color = currentColor;
        coloring_Brush_Mos_Lit.GetComponent<Image>().color = currentColor;
    }
    public void ChangeColor()
    {
        GameObject clickedObject = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        clickedObject.GetComponent<Image>().color = currentColor;
    }
    public void PaintButton(int colorCode)
    {
        switch (colorCode)
        {
            case 1:
                currentColor = new Color32(108, 139, 188, 255);
                break;
            case 2:
                currentColor = new Color32(78, 102, 136, 255);
                break;
            case 3:
                currentColor = new Color32(131, 131, 131, 255);
                break;
            case 4:
                currentColor = new Color32(22, 42, 69, 255);
                break;
            case 5:
                currentColor = new Color32(236, 162, 40, 255);
                break;
            default:
                currentColor = new Color32(176, 176, 176, 255);
                break;
        }
        ChangeBrushColorMosque();
    }
    public void ResetColoringMos()
    {
        currentColor = Color.white;
        ChangeBrushColorMosque();
        for (int i = 0; i < coloring_Buttons_Mosque.Length; i++)
        {
            coloring_Buttons_Mosque[i].image.color = Color.white;
        }
        coloring_FinishPanel.SetActive(false);
    }
    public void FinishPanel()
    {
        sounds.Play();
        coloringMos_FinishPanel.SetActive(true);
    }
}
