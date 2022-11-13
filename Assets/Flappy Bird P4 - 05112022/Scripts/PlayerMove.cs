using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        var verticalInput = Input.GetAxis("Vertical");

        var movement = new Vector3(1f, verticalInput, 0);

        transform.Translate(movement * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Duarrr!");
    }
}
