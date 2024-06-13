using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float currenthealth;

    public delegate void HealthIncreased();
    public static HealthIncreased healthIncreased;

    public delegate void HealthDecreased();
    public static HealthDecreased healthDecreased;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Give Health"))
        {
            healthIncreased?.Invoke();
        }
        if (other.gameObject.CompareTag("Take Health"))
        {
            healthIncreased?.Invoke();
        }
    }
}