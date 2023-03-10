using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;

    private Vector3 tempPos;

    [SerializeField]
    private float minX, maxX;


    private void Start()
    {
         player = GameObject.FindWithTag("Player").transform;
        //Debug.Log("The selected index: " + GameManager.instance.CharIndex);
    }

    private void LateUpdate() // lateupdate runs when all calculations are done in update
    {
        if (!player) // check player null or not
            return;

        tempPos = transform.position;
        tempPos.x = player.position.x;

        if (tempPos.x<minX)
        {
            tempPos.x = minX;
        }
        if(tempPos.x>maxX)
        {
            tempPos.x = maxX;
        }

        transform.position = tempPos;
    }
}
