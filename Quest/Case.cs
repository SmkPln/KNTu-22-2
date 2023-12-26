using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Case : MonoBehaviour
{
    public GameObject CaseOpen;
    public GameObject CaseClose;
    public GameObject photo1;

    private void OnMouseDown()
    {
        CaseOpen.SetActive(false);
        CaseClose.SetActive(true);
        photo1.SetActive(true);
    }
}
