using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorCastillo : MonoBehaviour
{

    private Component[] componentes;
    private string texto = "";
    private Rect rectangulo;
	void Start ()
    {
        rectangulo = new Rect(0, 0, 0, 0);
	}
	

	void Update ()
    {
        componentes = GetComponentsInChildren<Rigidbody>();
        if(componentes.Length == 0)
        {
            texto = "Has Ganado!";
            rectangulo = new Rect(10, 10, 200, 45);
            Invoke("CargarJuego", 2f);
        }
    }

    public void ActivarGravedad()
    {
        componentes = GetComponentsInChildren<Rigidbody>();
        foreach(Rigidbody rg in componentes)
        {
            rg.isKinematic = false;
            rg.useGravity = true;
        }

        Debug.Log("Activado");
    }

    public void DesactivarGravedad()
    {
        componentes = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rg in componentes)
        {
            rg.isKinematic = true;
            rg.useGravity = false;
        }
        Debug.Log("Desactivado");
    }

    void OnGUI()
    {
        GUI.skin.textField.fontSize = 30;
        GUI.TextField(rectangulo, texto);
    }

    private void CargarJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }


}
