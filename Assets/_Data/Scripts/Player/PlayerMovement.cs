using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : PlayerAbstract
{
    [SerializeField] protected float moveSpeed = 500f;
    [SerializeField] protected float moveDirection;

    protected override void Update()
    {
        base.Update();
        this.GetDirection();
    }

    private void FixedUpdate()
    {
        this.Move();
    }

    protected virtual void GetDirection()
    {
        this.moveDirection = InputManager.Instance.X_Input;
    }

    protected virtual void Move()
    {
        this.playerCtrl.PlayerRB.AddForce(transform.parent.right * this.moveDirection * this.moveSpeed * Time.fixedDeltaTime);
    }
}
