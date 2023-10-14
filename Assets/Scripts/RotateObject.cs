using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.Rotate(0, Time.deltaTime * _speed, 0);
    }
}
