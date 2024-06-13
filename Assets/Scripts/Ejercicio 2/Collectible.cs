using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public delegate void CollectibleEvent();
    public static CollectibleEvent colllectibleEvent;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            colllectibleEvent?.Invoke();
           
        }
    }
}
