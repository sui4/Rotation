using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorController : MonoBehaviour
{

    public bool ray = false;
    private bool trigStay = false;

    public Renderer renderer;
    //public Material material;
    private MaterialPropertyBlock materialPropertyBlock;

    private Vector3 localPos;
    public Vector4 quatLocalPos;
    private int quatLocalPosID;

    // Start is called before the first frame update
    void Start()
    {
        quatLocalPosID = Shader.PropertyToID("_QuatLocalPos");
        materialPropertyBlock = new MaterialPropertyBlock();
    }

    // Update is called once per frame
    void Update()
    {
        localPos = transform.localPosition;

        quatLocalPos = new Vector4(localPos.x, localPos.y, localPos.z, 1.0f);
        materialPropertyBlock.SetVector(quatLocalPosID, quatLocalPos);
        renderer.SetPropertyBlock(materialPropertyBlock);

        //if(!trigStay && ray)
        //{

        //}
        //else
        //{
        //}
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
