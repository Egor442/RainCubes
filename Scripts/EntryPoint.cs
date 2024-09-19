using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;

    private void Awake()
    {
        _spawner.Initialize();
    }
}