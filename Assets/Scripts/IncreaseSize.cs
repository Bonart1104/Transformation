using UnityEngine;

public class IncreaseSize : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _maxSize;

    private float _size;

    void Update()
    {
        if (_maxSize >= _size)
        {
            transform.localScale += new Vector3(Time.deltaTime * _speed, Time.deltaTime * _speed, Time.deltaTime * _speed);
           
            _size = transform.localScale.x;
        }
    }
}
