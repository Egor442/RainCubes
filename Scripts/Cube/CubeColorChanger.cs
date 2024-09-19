using UnityEngine;

[RequireComponent (typeof(MeshRenderer))]
public class CubeColorChanger : MonoBehaviour
{
    public void TryChangeColor()
    {
        GetComponent<MeshRenderer>().material.color = ColorChanger.GetRandomColor();
    }
}