using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerWert : MonoBehaviour
{
    public int Rechenwert;
    public Text Scorechange;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            Scorechange.text = "Wert: " + Rechenwert;

        }
    }
}
