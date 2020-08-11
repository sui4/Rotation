using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject rotateTarget;
    public float rotateAngle;
    
    // Start is called before the first frame update
    void Start()
    {
        rotateAngle = 0;
    }

    // Update is called once per frame
    void Update()
    {
        rotateTarget.transform.rotation = Quaternion.AngleAxis(rotateAngle, this.transform.position);
    }
}
