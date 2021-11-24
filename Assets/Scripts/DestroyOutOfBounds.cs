using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float downBound = -3.0f;
    
    // Update is called once per frame
    void Update()
    {
        //AND x && y => se deben cumplir x e y a la vez
        //OR x || y => se deben cumplir x o y, uno u otro (o los dos a la vez)
        
        /*if (this.transform.position.z > topBound || this.transform.position.z < downBound) 
        {
            Destroy(this.gameObject);
        }*/
        if (this.transform.position.z > topBound) 
        {
            Destroy(this.gameObject);
        }
        else if (this.transform.position.z < downBound) 
        {
            Debug.Log("FIIIIIIN");
            Destroy(this.gameObject);

            Time.timeScale = 0f;
        }
    }
    
}
