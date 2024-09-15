using DG.Tweening;
using UnityEngine;

public class ScaleRepeat : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_scale, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(_repeats, _loopType);
    }
}
