using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenColor : TweenBase
{
    [SerializeField] private Color EndValue;
    [SerializeField] private float Delay;

    private void Start()
    {
        Color originalColor = Image.color;

        Image.DOColor(EndValue, Duration).SetDelay(Delay).SetLoops(3).OnComplete(() =>
        {
            Image.color = originalColor;
        });
    }
}
