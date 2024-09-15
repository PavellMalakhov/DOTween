using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChange : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText("Это текст", _duration));
        sequence.Append(_text.DOText(", который последовательно меняется", _duration).SetRelative());
        sequence.Append(_text.DOText("разными способами!", _duration, true, ScrambleMode.All));
        sequence.SetLoops(-1, LoopType.Restart);
    }
}
