using UnityEngine;
using DG.Tweening;

public class Patrol : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _distanceMovementX;

    private void Start()
    {
        transform.DOMoveX(_distanceMovementX, _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
