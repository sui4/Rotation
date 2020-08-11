using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePerpendicular : MonoBehaviour
{
    public Transform vecInitial;
    public Transform vecTerminal;

    private float rotateAngle;


    // Update is called once per frame
    void Update()
    {

        this.transform.position = vecInitial.position;
        //Vector3 dirction = vecTerminal.transform.position - vecInitial.transform.position;
        Vector3 direction = vecTerminal.position;
        this.transform.up = direction;

    }
}
