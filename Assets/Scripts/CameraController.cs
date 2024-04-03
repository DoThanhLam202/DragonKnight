using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] float speed;
    private float curX;
    private Vector3 veclocity = Vector3.zero;

    private void Update()
    {
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(curX, transform.position.y, transform.position.z), ref veclocity, speed);
    }

    public void moveToNew(Transform newMove)
    {
        curX = newMove.position.x;
    }
}
