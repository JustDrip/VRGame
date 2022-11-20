using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Operation : MonoBehaviour
{
    public string Operationplusminus;
    public Text Scorechange;

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            Scorechange.text = Scorechange.text + " " + Operationplusminus;

        }
    }
}
