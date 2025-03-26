using UnityEngine;

[CreateAssetMenu(fileName = "Colour Palette")]
public class ColourPalette : ScriptableObject
{
    public Color borderColour = new Color(0, 0, 0, 1);
    public Color boxColour = new Color(0, 0, 0, 1);
    public Color textColour = new Color(0, 0, 0, 1);
    public Color backgroundColour = new Color(0, 0, 0, 1);
    public Color dotsColour = new Color(0, 0, 0, 1);
}
