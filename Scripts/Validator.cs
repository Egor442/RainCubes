using UnityEngine;

public static class Validator
{
    public static void Validate(float currentValue, float minValue, float maxValue)
    {
        currentValue = Mathf.Clamp(currentValue, minValue, maxValue);

        if (minValue >= maxValue)
        {
            minValue = maxValue - 1;
        }
    }
}