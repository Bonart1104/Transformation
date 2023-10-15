using UnityEngine;

public class IncreaseSize : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _minSize;
    [SerializeField] private float _maxSize;

    private float _size;

    private void Update()
    {
            transform.localScale = new Vector3(Mathf.PingPong(Time.time * _speed, _maxSize - _minSize) + _minSize, Mathf.PingPong(Time.time * _speed, _maxSize - _minSize) + _minSize, Mathf.PingPong(Time.time * _speed, _maxSize - _minSize) + _minSize);
    }
}
