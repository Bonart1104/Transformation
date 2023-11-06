using UnityEngine;
using DG.Tweening;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _yAngleValue;

    private void Start()
    {
        transform.DORotate(new Vector3(0, _yAngleValue, 0), _duration, RotateMode.Fast).SetEase(Ease.Linear).SetLoops(-1);
    }
}
