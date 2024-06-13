using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthDisplay : MonoBehaviour
{

    public TextMeshProUGUI healthText;
    private int MaxHealth;
    private int MinHealth;
    private void AgregarVida()
    {
        MaxHealth++;
        healthText.text = "healt:" + MaxHealth;
    }
    private void OnEnable()
    {
        PlayerHealth.healthIncreased += AgregarVida;
        PlayerHealth.healthDecreased += RestarVida;
    }
    private void OnDisable()
    {
        PlayerHealth.healthIncreased -= AgregarVida;
        PlayerHealth.healthDecreased -= AgregarVida;

    }
    private void RestarVida()
    {
        MinHealth--;
        healthText.text = "healt:" + MinHealth;
    }
}
