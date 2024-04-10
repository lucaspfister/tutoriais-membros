using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupManager : MonoBehaviour
{
    [SerializeField] private PopupUI PopupUI;

    void Start()
    {
        //PopupUI.Show("Warning", "You have no funds left for this purchase", "OK", PopupCallback);
        PopupUI.Show(
            title: "Confirmation", 
            description: "Do you want to buy this item?", 
            buttonText: "YES", 
            buttonCallback: () => Debug.Log("Yes"),
            button2Text: "NO",
            button2Callback: () => Debug.Log("No"));
    }

    private void PopupCallback()
    {
        Debug.Log("Callback done");
    }
}
