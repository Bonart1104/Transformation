using UnityEngine;
using DG.Tweening;

public class MovementForward : MonoBehaviour
{

    [SerializeField] private float _duration;
    [SerializeField] private float _maxScale;
    [SerializeField] private float _xAngleValue;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        
        sequence.Append(transform.DOMoveX(3, _duration).SetRelative());
        sequence.Insert(0, transform.DORotate(new Vector3(_xAngleValue, 0, 0 ), _duration));
        sequence.Insert(0, transform.DOScale(new Vector3(_maxScale, _maxScale, _maxScale), _duration));

        sequence.SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
