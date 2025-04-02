using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PaletteMaster : MonoBehaviour
{
    public GameObject[] border;
    public GameObject[] box;
    public GameObject[] text;
    public Image dots;

    public ColourPalette currentPalette;

    public ColourPalette currentPaletteProperty
    {
        get
        {
            return currentPalette;
        }

        set
        {
            currentPalette = value;
            Camera.main.backgroundColor = currentPalette.backgroundColour;

            dots.color = currentPalette.dotsColour;

            foreach (GameObject i in border)
            {
                i.GetComponent<Image>().color = currentPalette.borderColour;
            }

            foreach (GameObject i in box)
            {
                i.GetComponent<Image>().color = currentPalette.boxColour;
            }

            foreach (GameObject i in text)
            {
                i.GetComponentInChildren<TMP_Text>().color = currentPalette.textColour;
            }
        }
    }

    void Start()
    {
        currentPaletteProperty = currentPalette;

        border = GameObject.FindGameObjectsWithTag("Border");
        box = GameObject.FindGameObjectsWithTag("Box");
        text = GameObject.FindGameObjectsWithTag("Text");
    }
}
