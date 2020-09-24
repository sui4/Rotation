using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePerpendicularRotate : MonoBehaviour
{
    public Transform vecInitial;
    public GameObject vecTerminal;
    
    private float rotateAngle;


    // Update is called once per frame
    void Update()
    {

        this.transform.position = vecInitial.position;
        //Vector3 dirction = vecTerminal.transform.position - vecInitial.transform.position;
        Vector3 direction = vecTerminal.transform.position;
        //Debug.Log(direction);
        this.transform.up = direction;

        rotateAngle = vecTerminal.GetComponent<Rotate>().rotateAngle;
        this.transform.rotation = Quaternion.AngleAxis(rotateAngle, transform.up) * this.transform.rotation;
        //Debug.Log(transform.up);
    }
}
