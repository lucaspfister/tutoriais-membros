using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenMove : TweenBase
{
    [SerializeField] private float EndValue;
    [SerializeField] private Ease Ease;

    private void Start()
    {
        Rect.DOLocalMoveX(EndValue, Duration).SetEase(Ease);
    }
}
