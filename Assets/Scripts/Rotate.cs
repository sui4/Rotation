using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotate : MonoBehaviour
{
    public GameObject rotateTarget;
    public float rotateAngle;
    public GameObject SliderObj;
    private Slider slider;
    private Vector3 rotAxis;
    // Start is called before the first frame update
    void Start()
    {
        rotateAngle = 0;
        slider = SliderObj.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        rotateAngle = slider.value;

        rotAxis = this.transform.position - rotateTarget.transform.position;
        rotateTarget.transform.rotation = Quaternion.AngleAxis(rotateAngle, rotAxis);
        //rotateTarget.transform.rotation = Quaternion.AngleAxis(rotateAngle, this.transform.position);

        this.transform.rotation = Quaternion.FromToRotation(Vector3.up, rotAxis);
        //this.transform.rotation = Quaternion.AngleAxis(rotateAngle, rotAxis);

    }
}
