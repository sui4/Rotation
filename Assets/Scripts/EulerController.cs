using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EulerController : MonoBehaviour
{
    public GameObject sliderObj;
    private Slider slider;
    public Vector3 rotAxis = new Vector3(1,0,0);

    // Start is called before the first frame update
    void Start()
    {
        slider = sliderObj.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localEulerAngles = rotAxis * GetSliderValue();
    }

    private float GetSliderValue()
    {
        return slider.value;
    }
}
