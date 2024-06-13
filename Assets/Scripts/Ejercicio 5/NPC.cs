using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public delegate void NPCInteract();
    public static NPCInteract npcInteract;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            npcInteract?.Invoke();
        }
    }
}
