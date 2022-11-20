using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Checkpoint : MonoBehaviour
{
    public Text Score;
    public GameObject Wand;

    // Update is called once per frame
    void Update()
    {
        if (Score.text == "Wert: 250")
        {
            Wand.active = false;
        }
        else if (Score.text == "Wert: 250 +") {
            Wand.active = false;
        }
        else if (Score.text == "Wert: 250 + 250")
        {
            Wand.active = false;
            Score.text = "Geschafft";
        }
    }
}
