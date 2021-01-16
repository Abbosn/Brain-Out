using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OutOfaVision : MonoBehaviour
{
    public GameObject black;
    public GameObject yesPrefab;
    public GameObject tree;
    public GameObject winDisplay;
    public GameObject sun;
    public Image sleepingOwl;
    public Sprite owl;
   
    void Update()
    {
        if(sun.transform.localPosition.y > 560.0f || sun.transform.localPosition.y < -560.0f || sun.transform.localPosition.x < -300.0f || sun.transform.localPosition.x > 300.0f)
        {
            StartCoroutine(winLevelCo());
        }
    }

    IEnumerator winLevelCo()
    {
        Instantiate(yesPrefab, tree.transform);
        black.SetActive(true);
        sleepingOwl.overrideSprite = owl;
        sun.SetActive(false);
        yield return new WaitForSeconds(1.0f);
        winDisplay.SetActive(true);
    }
}