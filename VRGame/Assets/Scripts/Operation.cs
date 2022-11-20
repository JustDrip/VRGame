using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Operation : MonoBehaviour
{
    public string Operationplusminus;
    public Text Scorechange;
    public GameObject Wand;
    public GameObject collider;

    void OnTriggerEnter(Collider other)
    {

        /*if (other.CompareTag("Player"))
        {*/

            Scorechange.text = Scorechange.text + " " + Operationplusminus;
            if (Scorechange.text == "Wert: 250 +")
            {
                Wand.active = false;
            collider.active = false;
            }
       // }
    }
}
