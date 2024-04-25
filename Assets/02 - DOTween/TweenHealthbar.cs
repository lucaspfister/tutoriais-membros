using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenHealthbar : TweenBase
{
    [SerializeField] private float EndValue;
    [SerializeField] private float Delay;
    [SerializeField] private Ease Ease;

    private void Start()
    {
        Image.DOFillAmount(EndValue, Duration).SetDelay(Delay).SetEase(Ease);
    }
}
