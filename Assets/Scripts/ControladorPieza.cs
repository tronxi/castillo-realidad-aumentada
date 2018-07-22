using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPieza : MonoBehaviour
{
    public int estado;
    private Color[] colores = new Color [4];
   
	// Use this for initialization
	void Start ()
    {

        colores[0] = Color.red;
        colores[1] = Color.green;
        colores[2] = Color.yellow;
        colores[3] = Color.blue;

        if (estado >= colores.Length)
        {
            estado = colores.Length - 1;
        }
        else if(estado < 0)
        {
            estado = 0;
        }
        GetComponent<Renderer>().material.color = colores[estado];

    }
	
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "disparo")
        {
            if (estado == 0)
            {
                Destroy(this.gameObject);
            }
            else
            {
                estado--;
                GetComponent<Renderer>().material.color = colores[estado];
            }
        }
    }
}
