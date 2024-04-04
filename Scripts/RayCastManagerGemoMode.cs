using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class RayCastManagerGemoMode : MonoBehaviour
{


    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = 2;
    }
 


    public GameObject cube;
    // Update is called once per frame
    void Update()
    {
      Ray ray = new Ray(this.transform.position, cube.transform.position);
         // Ray ray = new Ray(this.transform.position, this.transform.forward);
        RaycastHit hitData;
        if (Physics.Raycast(ray, out hitData))
        {
            Debug.DrawRay(ray.origin, ray.direction * 20, Color.green, 2, false);
            GameObject hitObject = hitData.transform.gameObject;
            Debug.Log(hitObject.tag);
        }

        // Update the line points
        lineRenderer.SetPosition(0, this.transform.position);
        lineRenderer.SetPosition(1, cube.transform.position);
    }
}