using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull;
    public GameObject[] slots;
    public GameObject inventory;
    private bool inventotyOn;

    private void Start()
    {
        inventotyOn = false;
    }
    public void Inventar()
    {
        if (inventotyOn == false)
        {
            inventotyOn = true;
            inventory.SetActive(true);
        }
        else if (inventory == true)
        {
            inventotyOn = false;
            inventory.SetActive(false);
        }
    }    
}
