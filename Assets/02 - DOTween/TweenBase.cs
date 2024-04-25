using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenBase : MonoBehaviour
{
    [SerializeField] protected float Duration;

    protected Image Image;
    protected RectTransform Rect;

    private void Awake()
    {
        Image = GetComponent<Image>();
        Rect = GetComponent<RectTransform>(); 
    }
}
