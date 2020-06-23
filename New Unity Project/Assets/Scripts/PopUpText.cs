using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpText : MonoBehaviour
{
    public Text popUpText;
    public float waitBeforePopUp;
    public float showPopUpFor;

    private void Start()
    {
        popUpText.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Makiroll"))
        {
            StartCoroutine("ShowText");
        }
    }

    //mostro il text per tot sec poi sparisce
    IEnumerator ShowText()
    {
        yield return new WaitForSeconds(waitBeforePopUp);
        popUpText.enabled = true;
        yield return new WaitForSeconds(showPopUpFor);
        popUpText.enabled = false;
        yield return null;
    }

}
