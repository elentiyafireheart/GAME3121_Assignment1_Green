using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
       // transform.position = new Vector3(1.77f,1.19f,-1.2f);
        //transform.rotation = Quaternion.Euler(0, -90, 0);
       //transform.position = plane.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
