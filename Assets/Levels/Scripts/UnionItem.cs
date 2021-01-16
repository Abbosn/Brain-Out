using UnityEngine;
using UnityEngine.EventSystems;

public class UnionItem : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
        if (eventData.pointerDrag != null)
        {

            if (transform.localScale.x  == eventData.pointerDrag.transform.localScale.x)
            {
                Destroy(eventData.pointerDrag);
                transform.localScale += new Vector3(0.5f, 0.5f, 0);
            }else if (transform.localScale.x > eventData.pointerDrag.transform.localScale.x)
            {
                Destroy(eventData.pointerDrag);
                transform.localScale += new Vector3(0.3f, 0.3f, 0);
            }else if (transform.localScale.x < eventData.pointerDrag.transform.localScale.x)
            {
                Destroy(this.gameObject);
                eventData.pointerDrag.transform.localScale += new Vector3(0.16f, 0.16f, 0);
            }
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
        }
    }
    
}
