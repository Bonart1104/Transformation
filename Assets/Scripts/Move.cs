using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.localScale += new Vector3(Time.deltaTime * _speed, Time.deltaTime * _speed, Time.deltaTime * _speed);
        transform.Translate(Time.deltaTime * _speed, 0, 0);
        transform.Rotate(0, Time.deltaTime * _speed, 0);
    }
}
