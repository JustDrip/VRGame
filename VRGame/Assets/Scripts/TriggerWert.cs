using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TriggerWert : MonoBehaviour
{
    public int Rechenwert;
    public Text Scorechange;
    public GameObject Wand;



    void OnTriggerEnter(Collider other)
    {

       /* if (other.CompareTag("Player"))
        {*/

         Scorechange.text = "Wert: " + Rechenwert;
         if (Scorechange.text == "Wert: 250")
        {
            Wand.active = false;
        }
        // }
    }
}
