using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class InventItem : MonoBehaviour, IBeginDragHandler,IDragHandler, IEndDragHandler
{
    [Header("UI")]
    public Image image;
    Transform parentAfterDrag;
   public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Begin");

        //image.raycastTarget = false;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Draggin");

        transform.position = Input.mousePosition;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("End");

        transform.SetParent(parentAfterDrag);
    }
}
