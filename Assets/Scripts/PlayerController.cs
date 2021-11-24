using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 17.0f;
    public Vector2 zRange = new Vector2(-0.35f, 15.0f);
    public GameObject projectilePrefab;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //Movimiento del personaje
        if (transform.position.x < -xRange)
        {
            // Se sale de la pantalla por la izquierda
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            // Se sale de la pantalla por la derecha
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < zRange.x)
        {
            // Se sale de la pantalla por la izquierda
            transform.position = new Vector3(transform.position.x,transform.position.y, zRange.x);
        }
        if (transform.position.z > zRange.y)
        {
            // Se sale de la pantalla por la derecha
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange.y);
        }
        
        //Acciones del personaje
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Si estamos aquí hay que lanzar un proyectil
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
        
        
        
    }
}
