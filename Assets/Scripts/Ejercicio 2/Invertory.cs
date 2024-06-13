using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Invertory : MonoBehaviour
{

    public TextMeshProUGUI recolectablesText;

    private int contador;
  void Inventory()
    {
        contador++;
        recolectablesText.text = "objetos recolectados: " + contador;
    }

    private void OnEnable()
    {
        Collectible.colllectibleEvent += Inventory;
    }

    private void OnDisable()
    {
        Collectible.colllectibleEvent -= Inventory;
    }
}
