using UnityEngine;

public static class ColorChanger
{
    public static Color GetRandomColor()
    {
        float colorChannelR = Random.value;
        float colorChannelG = Random.value;
        float colorChannelB = Random.value;

        return new Color(colorChannelR, colorChannelG, colorChannelB);
    }
}