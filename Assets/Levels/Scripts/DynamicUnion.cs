using UnityEngine;
using UnityEngine.UI;
using System;

public class DynamicUnion : MonoBehaviour
{
    public Button[] buttons;
    public void CheckForSize()
    {   
        if (buttons[3].transform.localScale.x  > 2.3f)
        {
            Debug.Log("Win!");
        }
        else
        {
            Debug.Log("No!");
        }
        
    }
}
