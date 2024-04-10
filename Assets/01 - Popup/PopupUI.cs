using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class PopupUI : MonoBehaviour
{
    [SerializeField] private Canvas Canvas;
    [SerializeField] private TextMeshProUGUI Title;
    [SerializeField] private TextMeshProUGUI Description;
    [SerializeField] private Button Button1;
    [SerializeField] private Button Button2;
    [SerializeField] private TextMeshProUGUI Button1Text;
    [SerializeField] private TextMeshProUGUI Button2Text;

    private Action Button1Callback;
    private Action Button2Callback;

    private void Awake()
    {
        Button1.onClick.AddListener(OnButton1Click);
        Button2.onClick.AddListener(OnButton2Click);
    }

    public void Show(string title, string description, string buttonText, Action buttonCallback, string button2Text = null, Action button2Callback = null)
    {
        Title.text = title;
        Description.text = description;

        Button1Text.text = buttonText;
        Button1Callback = buttonCallback;

        Button2Text.text = button2Text;
        Button2Callback = button2Callback;

        bool displayButton2 = !string.IsNullOrEmpty(button2Text);
        Button2.gameObject.SetActive(displayButton2);

        Canvas.enabled = true;
    }

    public void Hide()
    {
        Canvas.enabled = false;
    }

    private void OnButton1Click()
    {
        Button1Callback?.Invoke();
        Hide();
    }

    private void OnButton2Click()
    {
        Button2Callback?.Invoke();
        Hide();
    }
}
