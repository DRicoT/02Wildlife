using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour
{
    //OnTriggerEnter se llamará automáticamente cuando
    //un objeto físico entre dentro del Trigger del Game Object
    private void OnTriggerEnter(Collider other) //Other, sería el objecto que entre en el trigger
    {
        Destroy(this.gameObject); //Destruye el enemigo
        Destroy(other.gameObject); //Destruye al "otro"
    }
}
