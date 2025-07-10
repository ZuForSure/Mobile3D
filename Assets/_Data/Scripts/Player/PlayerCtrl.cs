using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : ZuMonoBehaviour
{
    [SerializeField] protected Rigidbody playerRb;
    public Rigidbody PlayerRB => playerRb;

    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadRigibody();
    }

    protected virtual void LoadRigibody()
    {
        if (this.playerRb != null) return;
        this.playerRb = transform.GetComponent<Rigidbody>();
        Debug.Log(transform.name + ": LoadRigibody", gameObject);
    }
}
