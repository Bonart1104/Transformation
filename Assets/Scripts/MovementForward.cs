using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Translate(Time.deltaTime * _speed, 0, 0);
    }
}
