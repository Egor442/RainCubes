using System.Collections;
using UnityEngine;

public class CubeVanisher : MonoBehaviour
{
    [SerializeField] private int _minLifeTime;
    [SerializeField] private int _maxLifeTime;

    private int _lifeTime;

    private void Start()
    {
        _lifeTime = Random.Range(_minLifeTime, _maxLifeTime + 1);
    }

    private void OnValidate()
    {
        Validator.Validate(_lifeTime, _minLifeTime, _maxLifeTime);
    }
    
    public IEnumerator Vanish()
    {
        yield return new WaitForSeconds(_lifeTime);
        gameObject.SetActive(false);
    }
}