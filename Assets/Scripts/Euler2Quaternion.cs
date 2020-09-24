using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Euler2Quaternion : MonoBehaviour
{
    public GameObject target;
    public GameObject[] sliderObjs = new GameObject[3];
    private Slider[] sliders = new Slider[3];

    private Vector3 rotEuler;
    public Quaternion rot;
    private Vector3 vec;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<3; i++)
        {
            sliders[i] = sliderObjs[i].GetComponent<Slider>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        FetchSliderValues();
        rot = Quaternion.Euler(rotEuler);
        vec = new Vector3(rot.x, rot.y, rot.z);
        vec.Normalize();
        this.transform.localPosition = vec;
        this.transform.localRotation = rot;

        this.transform.localRotation = Quaternion.FromToRotation(Vector3.up, vec);

        //target.transform.rotation = rot;
        target.transform.localRotation = rot;

    }

    private void FetchSliderValues()
    {
        for(int i=0; i<3; i++)
        {
            rotEuler[i] = sliders[i].value;
        }

    }
}
