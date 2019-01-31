using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceInteraction : MonoBehaviour
{
    public float okDistance = 2.0f;
    public GameObject objectTrack;

    public GameObject light;

    void Update()
    {
    	float dist = Vector3.Distance(objectTrack.transform.position, transform.position);
    	if (dist < okDistance)
    	{
    		PerformToClose();
    	}
    	else
    	{
			light.GetComponent<Light>().intensity = 2;
    	}
    }
    void PerformToClose()
    {
    	//Debug.Log("To Close");
    	light.GetComponent<Light>().intensity = 20;
    }
}
