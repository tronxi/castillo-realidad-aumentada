using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverDisparo : MonoBehaviour
{
    private int velocidad = 5;
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
       
    }

    void FixedUpdate()
    {
        transform.Translate((Vector3.forward * Time.fixedDeltaTime) * velocidad);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
