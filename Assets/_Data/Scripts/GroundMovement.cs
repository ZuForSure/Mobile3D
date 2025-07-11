using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : ZuMonoBehaviour
{
    [SerializeField] protected float groundSpeed = 5f;
    [SerializeField] protected bool canMove = false;

    protected override void Update()
    {
        base.Update();
        if (!this.canMove) return;
        this.GroundMoving();
    }

    //private void FixedUpdate()
    //{
    //    if (!this.canMove) return;
    //    this.GroundMoving();
    //}

    protected virtual void GroundMoving()
    {
        transform.parent.Translate(Vector3.back * this.groundSpeed * Time.deltaTime);
    }
}
