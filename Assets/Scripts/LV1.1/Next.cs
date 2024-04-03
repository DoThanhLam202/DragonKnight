using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Next : MonoBehaviour
{
    [SerializeField] private Transform beforeLv;
    [SerializeField] private Transform afterLv;
    [SerializeField] private CameraController cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(collision.transform.position.x < transform.position.x)
            {
                cam.moveToNew(afterLv);
            }
            else
            {
                cam.moveToNew(beforeLv);
            }
        }
    }
}
