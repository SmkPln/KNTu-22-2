using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luck : MonoBehaviour
{
    public GameObject LuckOpen;
    public GameObject LuckClose;
    public GameObject phota2;

    private void OnMouseDown()
    {
        LuckOpen.SetActive(false);
        LuckClose.SetActive(true);
        phota2.SetActive(true);
    }
}
