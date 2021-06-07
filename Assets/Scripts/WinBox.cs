using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.name == "Vehicles_PizzaCar1")
        {
            Debug.Log("Vehicles_PizzaCar1");
            GameObject.Find("Vehicles_PizzaCar1").SendMessage("Finnish");
        } else if(other.name == "Vehicles_PizzaCar")
        {
            Debug.Log("Vehicles_PizzaCar");
            GameObject.Find("Vehicles_PizzaCar").SendMessage("Finnish");
        }
    }
}
