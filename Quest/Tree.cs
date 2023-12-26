using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public GameObject TreeSpawn;
    public GameObject TreeDelete;
    public GameObject QuestObject3;

    private void OnMouseDown()
    {
        TreeSpawn.SetActive(true);
        TreeDelete.SetActive(false);
        QuestObject3.SetActive(true);
    }
}
