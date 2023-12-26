using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quests : MonoBehaviour
{
    public int questNumber;
    public int[] items;
    public GameObject barrier;
    public GameObject StartDialog;
    public GameObject StartDialog2;
    public Animator startAnim;
    public DialogueManager dm;
    public GameObject end;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag != "Player" && other.gameObject.GetComponent<Pickup>().id == items[questNumber])
        {
            questNumber++;
            Destroy(other.gameObject);
            CheckQuest();
        }
    }
    public void CheckQuest()
    {
        if (questNumber == 3)
        {
            barrier.SetActive(false);
            StartDialog.SetActive(false);
            StartDialog2.SetActive(true);
           
             startAnim.SetBool("startOpen", true);

        }
        if (questNumber == 7)
        {
            end.SetActive(true);

        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        StartDialog2.SetActive(false);
        startAnim.SetBool("startOpen", false);
        dm.EndDialogue();
    }
}
