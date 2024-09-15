using UnityEngine;
using DG.Tweening;

public class MoveRepeat : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_position, _duration)
            .SetEase(Ease.Linear)
            .SetLoops(_repeats, _loopType);
    }
}
