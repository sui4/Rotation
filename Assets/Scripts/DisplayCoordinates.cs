using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayCoordinates : MonoBehaviour
{
    public GameObject target;
    
    private Vector3 targetPos;
    private float rotateAngle;
    private Text text;
    void Start()
    {
        text = this.GetComponent<Text>();
    }

    void Update()
    {
        targetPos = target.transform.position;
        rotateAngle = target.GetComponent<Rotate>().rotateAngle;

        //text.text = "(" + targetPos.x.ToString() +
        //            ", " + targetPos.y.ToString() +
        //            ", " + targetPos.z.ToString() +
        //            ", " + rotateAngle + ")";
        text.text = "θ : " + rotateAngle;

    }
}
