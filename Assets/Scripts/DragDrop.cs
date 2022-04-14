using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler{
    [SerializeField] private Canvas canvas;

    public GameObject myParent;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;

    private void Awake(){
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

   public void OnPointerDown(PointerEventData eventData) {
   }

   public void OnBeginDrag(PointerEventData eventData) {

        if (this.myParent != null)
        {
            myParent.GetComponent<ItemSlot>().myChild = null;
            myParent = null;
        }

        canvasGroup.alpha = .6f;
        canvasGroup.blocksRaycasts = false;
    }

   public void OnEndDrag(PointerEventData eventData) {
       canvasGroup.blocksRaycasts = true;
       canvasGroup.alpha = 1f;
   }

   public void OnDrag(PointerEventData eventData) {
       rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
   }
}
