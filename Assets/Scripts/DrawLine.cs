using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    public GameObject origin;
    public GameObject target;

    private Vector3 originPos, targetPos;
    private LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = this.GetComponent<LineRenderer>();
        lineRenderer.startWidth = 0.01f;
        lineRenderer.endWidth = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        originPos = origin.transform.position;
        targetPos = target.transform.position;

        lineRenderer.SetPosition(0, originPos);
        lineRenderer.SetPosition(1, targetPos);
    }
}
