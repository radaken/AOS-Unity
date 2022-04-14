using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler{
    [SerializeField] public GameObject ObjectAttached;
    public void OnDrop(PointerEventData eventData){
        if (eventData.pointerDrag != null){
            //Якорение dragging объекта
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            ObjectAttached = eventData.pointerDrag;
           // DINDropChecker(eventData);
           // eventData.pointerDrag.transform.SetParent(this.transform, false);
            Debug.Log(this.transform);
        }
    }
    public void DINDropChecker(PointerEventData eventData){
        switch(eventData.pointerDrag.name){
            case "PS60B":
                Debug.Log("It's PS60B!");
            break;
            case "IEC":
                Debug.Log("It's IEC!");
            break;
            case "PEV":
                Debug.Log("It's PEV!");
            break;
            case "PR200":
                Debug.Log("It's PR200!");
            break;
            default:
                Debug.LogError("No one from the switch-case list!");
            break;
        }
    }
}
