using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager_Scor : MonoBehaviour
{

    public Text numarare;


    void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);

    }

    
}
