using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public int velocidad = 1;
    private bool derecha;
    private bool izquierda;
    private bool arriba;
    private bool abajo;
    // Use this for initialization
    void Start ()
    {
        derecha = false;
        izquierda = false;
        arriba = false;
        abajo = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ArribaA();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            AbajoA();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            IzquierdaA();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            DerechaA();
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            Cancelar();
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            Cancelar();
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            Cancelar();
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            Cancelar();
        }
    }
    private void FixedUpdate()
    {
        if (arriba)
        {
            transform.Rotate((new Vector3(0f, 0f, 10f) * Time.fixedDeltaTime) * velocidad * 10);
        }
        if (abajo)
        {
            transform.Rotate((new Vector3(0f, 0f, -10f) * Time.fixedDeltaTime) * velocidad * 10);
        }
        if (izquierda)
        {
            transform.Rotate((new Vector3(0f, -10f, 0f) * Time.fixedDeltaTime) * velocidad * 10);
        }
        if (derecha)
        {
            transform.Rotate((new Vector3(0f, 10f, 0f) * Time.fixedDeltaTime) * velocidad * 10);
        }
    }

    public void ArribaA()
    {
        arriba = true;
    }

    public void AbajoA()
    {
        abajo = true;
    }

    public void IzquierdaA()
    {
        izquierda = true;
    }
    public void DerechaA()
    {
        derecha = true;
    }

    public void Cancelar()
    {
        derecha = false;
        izquierda = false;
        arriba = false;
        abajo = false;
    }
}
