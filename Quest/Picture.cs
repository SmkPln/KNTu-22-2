using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Picture : MonoBehaviour
{
    public GameObject Picture1;
    public GameObject Picture2;
    public GameObject photo33;

    private void OnMouseDown()
    {
        Picture1.SetActive(false);
        Picture2.SetActive(true);
        photo33.SetActive(true);
    }
}
