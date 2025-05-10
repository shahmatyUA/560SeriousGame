using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour, IDropHandler
{
    public string expectedCode;
    public TMP_Text dropText;

    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("hi");
        CodeBlock block = eventData.pointerDrag.GetComponent<CodeBlock>();
        if (block != null && dropText != null)
        {
            dropText.text = block.GetCode();
            block.gameObject.SetActive(false); // Optional: hide block after placement
            
        }
    }

    public bool IsCorrect()
    {
        return dropText != null && dropText.text == expectedCode;
    }
}
