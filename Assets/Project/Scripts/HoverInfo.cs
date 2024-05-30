using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HoverInfo : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject hoverObj;   // Reference to the Text component for info

    // Method called when the pointer enters the button area
    public void OnPointerEnter(PointerEventData eventData)
    {       
        hoverObj.gameObject.SetActive(true); // Show the text
    }

    // Method called when the pointer exits the button area
    public void OnPointerExit(PointerEventData eventData)
    {
        hoverObj.gameObject.SetActive(false); // Hide the text
    }
}
