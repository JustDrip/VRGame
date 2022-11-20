using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leave : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {

            Application.Quit();

        }
    }
}
