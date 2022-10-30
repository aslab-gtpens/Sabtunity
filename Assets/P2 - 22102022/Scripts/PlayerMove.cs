using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        var verticalInput = Input.GetAxis("Vertical");

        var movement = new Vector3(5f, verticalInput * speed, 0);

        transform.Translate(movement * Time.deltaTime);
    }
}
