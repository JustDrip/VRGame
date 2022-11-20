using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triggerergebnis : MonoBehaviour
{
    public int Rechenwert;
    public Text Scorechange;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            Scorechange.text = Scorechange.text + " " + Rechenwert;

        }
    }
}
