using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : LiveObject
{
    private void Start()
    {
        moveSpeed = 1f;
    }

    private void Update()
    {
        PlayerRotation();
    }

    public void PlayerRotation()
    {
        if (Input.GetKey(KeyCode.W))
            Move(Vector3.up);
    }
}
