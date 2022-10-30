using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        var offset = new Vector3(0, 0, -10);

        var position = target.position + offset;

        transform.position = position;
    }
}
