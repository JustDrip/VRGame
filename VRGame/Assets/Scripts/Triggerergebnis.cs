using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triggerergebnis : MonoBehaviour
{
    public int Rechenwert;
    public Text Scorechange;
    public GameObject Wand;
    public GameObject collider;

    void OnTriggerEnter(Collider other)
    {
            Scorechange.text = Scorechange.text + " " + Rechenwert;
            if (Scorechange.text == "Wert: 250 + 250")
            {
                Wand.active = false;
            collider.active = false;
            Scorechange.text = "Geschafft";
            }
    }
}
