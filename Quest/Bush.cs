using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bush : MonoBehaviour
{
    public GameObject BushSpawn;
    public GameObject BushDelete;
    public GameObject QuestObject2;

    private void OnMouseDown()
    {
        BushSpawn.SetActive(true);
        BushDelete.SetActive(false);
        QuestObject2.SetActive(true);
    }
}
