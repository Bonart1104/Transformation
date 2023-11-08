using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private  Text _text;

    private float _duration = 4f;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Текст изменился", _duration));
        sequence.Append(_text.DOText(" Текст дополнился", _duration).SetRelative());
        sequence.Append(_text.DOText("Текст взломался", _duration, true, ScrambleMode.All));
    }
}
