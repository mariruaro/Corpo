using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRLookWalk : MonoBehaviour
{

    public Transform VRCamera;

    public float toogleAngle = 30f;

    public float speed = 3f;

    public bool moveFoward;

    private CharacterController cc;



    void Start()
    {
        cc = GetComponentInParent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        if (VRCamera.eulerAngles.x >= toogleAngle && VRCamera.eulerAngles.x < 90.0f)
        {
            moveFoward = true;
        }
        else
        {
            moveFoward = false;
        }

        if (moveFoward)
        {
            Vector3 foward = VRCamera.TransformDirection(Vector3.forward);
            cc.SimpleMove(foward * speed);
            if (GetComponent<AudioSource>().isPlaying == false)
                //GetComponent<AudioSource> ().volume = Random.Range (0.19f, 0.25f);
                //GetComponent<AudioSource> ().pitch	= Random.Range (0.8f, 1f);
                GetComponent<AudioSource>().Play();
        }
    }


}
