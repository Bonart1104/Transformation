using UnityEngine;
using DG.Tweening;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _maxScale;

    private void Start()
    {
        transform.DOScale(new Vector3(_maxScale, _maxScale, _maxScale), _duration).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
