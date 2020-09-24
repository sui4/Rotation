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
        rotateTarget.transform.rotation = Quaternion.AngleAxis(rotateAngle, this.transform.position.normalized);
    }
}
