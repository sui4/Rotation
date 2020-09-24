using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuatModelController : MonoBehaviour
{
    public GameObject vec;
    public Renderer renderer;
    private MaterialPropertyBlock materialPropertyBlock;

    private Vector3 color;
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
        color = vec.transform.localPosition;

        quatLocalPos = new Vector4(color.x, color.y, color.z, 1.0f);
        materialPropertyBlock.SetVector(quatLocalPosID, quatLocalPos);
        renderer.SetPropertyBlock(materialPropertyBlock);

    }
}
