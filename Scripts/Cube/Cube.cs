using UnityEngine;

[RequireComponent(typeof(CubeColorChanger))]
[RequireComponent(typeof(CubeVanisher))]
public class Cube : MonoBehaviour
{
    private CubeColorChanger _cubeColorChanger;
    private CubeVanisher _cubeVanisher;

    private bool _colorChanged;

    private void Awake()
    {
        _cubeColorChanger = GetComponent<CubeColorChanger>();
        _cubeVanisher = GetComponent<CubeVanisher>();
    }

    private void OnEnable()
    {
        _colorChanged = false;
        GetComponent<MeshRenderer>().material.color = Color.white;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.TryGetComponent(out Platform platform))
        {
            if (_colorChanged == false)
            {
                _cubeColorChanger.TryChangeColor();
                _colorChanged = true;

                StartCoroutine(_cubeVanisher.Vanish());
            }
        }
    }
}