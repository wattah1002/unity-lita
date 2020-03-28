using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{

    public Transform target;
    public float speed = 0.001f;
    private Vector3 vec;
    Vector3 playerPos;
    public float distance;
    public GameObject player;
    public float trackingRange = 5f;
    public float quitRange = 10f;
    public bool tracking = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = player.transform.position;
        //Debug.Log(playerPos);
        distance = Vector3.Distance(this.transform.position, playerPos);
        //Debug.Log(distance);

        if (tracking == true)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), 0.3f);
            transform.position += transform.forward * speed;
            if (distance > quitRange)
            {
                tracking = false;
            }
        }
        else
        {
            if (distance < trackingRange)
            {
                tracking = true;
            }
        }
    }
}
