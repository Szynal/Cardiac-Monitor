using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    public Transform Camera;

    public float minScrollDownHeartDistance = 8.978218F;
    public float maxScrollUpHeartDistance = 5.478217F;

    private float cameraDistance;
    private Ray ray;
    private RaycastHit hit;

    public void Awake()
    {
        cameraDistance = Vector3.Distance(transform.position, Camera.position);
    }

    void Update()
    {

        cameraDistance = Vector3.Distance(transform.position, Camera.position);

        if (Input.GetMouseButton(0))
        {
            Camera cam = Camera.GetComponent<Camera>();
            ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.transform.CompareTag("Heart") == false)
                {
                    return;      
                }        
            }

            float h = horizontalSpeed * Input.GetAxis("Mouse X");
            float v = verticalSpeed * Input.GetAxis("Mouse Y");
            transform.Rotate(v, h, 0);

        }

        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            Camera cam = Camera.GetComponent<Camera>();
            ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Heart")==false)
                {
                    return;                    
                }
            }
            {
            if (cameraDistance > maxScrollUpHeartDistance)
                transform.position += CalculateDirection(Camera) * 0.5f;
            }
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            Camera cam = Camera.GetComponent<Camera>();
            ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.CompareTag("Heart"))
                {
                    if (cameraDistance < minScrollDownHeartDistance)
                    {
                        transform.position -= CalculateDirection(Camera) * 0.5f;
                    }
                }
            }


        }

    }

    public Vector3 CalculateDirection(Transform target)
    {
        Vector3 heading = target.position - transform.position;
        float distance = heading.magnitude;
        return heading / distance;
    }

}
