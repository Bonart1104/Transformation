using UnityEngine;

public class RotationObject : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(0, Time.deltaTime * _speed, 0);
    }
}
