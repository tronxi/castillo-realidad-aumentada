using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ControladorImagen : MonoBehaviour, ITrackableEventHandler
{
    public GameObject castillo;

    private TrackableBehaviour trackable;



    protected virtual void Start ()
    {
        trackable = GetComponent<TrackableBehaviour>();
        if(trackable)
        {
            trackable.RegisterTrackableEventHandler(this);
        }
	}
	
	void Update ()
    {

    }

    public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
    {

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            //Debug.Log("Trackable " + trackable.TrackableName + " found");
            OnTrackingFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            //Debug.Log("Trackable " + trackable.TrackableName + " lost");
            OnTrackingLost();
        }
        else
        {
            OnTrackingLost();
        }
    }

    protected virtual void OnTrackingFound()
    {
        castillo.GetComponent<ControladorCastillo>().ActivarGravedad();
    }

    protected virtual void OnTrackingLost()
    {
        castillo.GetComponent<ControladorCastillo>().DesactivarGravedad();
    }
}
