using UnityEngine;
using UnityEngine.EventSystems;

public class DragWithTouch : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler{

    private RectTransform rectTransform;
    public Canvas canvas;

    private void Awake()
    {
        this.rectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor * 1.0f;

    }

}
