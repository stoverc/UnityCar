using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset =  new Vector3(0,5,-10);
    private Vector3 offset2 = new Vector3(0,5,0);
    private bool cameraswitch = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        if(Input.GetKeyDown("s")){
            cameraswitch = !cameraswitch;
        }
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (cameraswitch == true){
            transform.position = player.transform.position + offset;
        }
        else { transform.position = player.transform.position + offset2; }
    }
}
