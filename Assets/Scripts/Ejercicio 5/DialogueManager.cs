using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private void Interaccion()
    {
        Debug.Log("Interaccion con NPC");
    }
    private void OnEnable()
    {
        NPC.npcInteract += Interaccion;
    }
    private void OnDisable()
    {
        NPC.npcInteract -= Interaccion;
    }
}
