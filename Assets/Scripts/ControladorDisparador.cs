using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDisparador : MonoBehaviour
{
    public GameObject prefab;

    private bool disparar = false;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.Space) || disparar)
        {
            CrearDisparo();
            disparar = false;
        }
    }


    public void CrearDisparo()
    {
        Vector3 posDisparo;
        posDisparo = new Vector3(transform.position.x, transform.position.y - 0.25f, transform.position.z);

        GameObject disparo =
            Instantiate(prefab, posDisparo, transform.rotation);
    }

    public void DispararA()
    {
        disparar = true;
    }
}
