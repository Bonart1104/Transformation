using UnityEngine;
using DG.Tweening;

public class Patrol : MonoBehaviour
{
    private void Start()
    {
        transform.DOMoveX(5, 2 ).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.Linear);
    }
}
