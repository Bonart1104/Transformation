using UnityEngine;
using DG.Tweening;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private Material _material;

    private void Start()
    {
        _material.DOColor(_color, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
