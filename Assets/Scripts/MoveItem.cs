using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveItem : MonoBehaviour
{
    public GameObject player;
    public GameObject item;

    private LayerMask mask;
    //private GameObject item1;
    private RaycastHit hit;

    VectorController vc_item1;
    // Start is called before the first frame update
    void Start()
    {
        vc_item1 = item.GetComponent<VectorController>();
        //mask = ~(1 << 8 | 1 << 9);
        mask = 1 << 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(player.transform.position, player.transform.forward, out hit, 1, mask))
        {
            vc_item1.ray = true;
            Debug.DrawRay(player.transform.position, player.transform.transform.forward * hit.distance, Color.yellow);

            if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger) || OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
            {
                item.transform.position = hit.point; // Cubeをレイの当たったところに移動
                item.transform.rotation = Quaternion.FromToRotation(item.transform.up, hit.normal); // Cubeの上方向をレイが当たったところの表面の方向にする
                item.transform.position += item.transform.localScale.y / 1.98f * hit.normal; // Cubeが埋まらないように、表面方向に少し動かす
            }
        }
        else
        {
            vc_item1.ray = false;

        }
    }
}
