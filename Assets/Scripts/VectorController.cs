using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorController : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Color defaultColor;
    private Color defaultColor_Transparent;

    public bool ray = false;
    private bool trigStay = false;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        defaultColor = new Color(1, 1, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!trigStay && ray)
        {
            meshRenderer.material.SetColor("_BaseColor", defaultColor);

        }
        else
        {
            meshRenderer.material.SetColor("_BaseColor", Color.red);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        trigStay = true;
    }
    private void OnTriggerExit(Collider other)
    {
        trigStay = false;
    }
}
