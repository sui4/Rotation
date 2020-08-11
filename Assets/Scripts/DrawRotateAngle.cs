using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawRotateAngle : MonoBehaviour
{
    public Transform initial;
    public Transform terminal;

    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = this.GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.01f;
        lineRenderer.endWidth = 0.01f;

        lineRenderer.SetPosition(0, initial.position);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < lineRenderer.positionCount; i++)
        {
            //transform.position = Quaternion.Slerp(initial.rotation, terminal.rotation, i/(float)lineRenderer.positionCount) * initial.position;
            Vector3 pos = Vector3.Lerp(initial.position, terminal.position, i / (float)lineRenderer.positionCount);

            lineRenderer.SetPosition(i, pos);
        }
        


        
    }
}
