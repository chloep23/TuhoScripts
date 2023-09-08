using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour
{
    public float MoveSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        // Walking Function 
        Vector3 direction = new Vector3(-Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        transform.position += direction * MoveSpeed * Time.deltaTime;
        transform.LookAt(transform.position + direction); //rotating character when walking
    }
}
