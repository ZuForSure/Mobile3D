using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : ZuMonoBehaviour
{
    protected static InputManager instance;
    public static InputManager Instance => instance;

    [SerializeField] protected float horizontalInput;
    public float X_Input => horizontalInput;

    protected override void Awake()
    {
        if (instance != null) Debug.LogWarning("Only 1 InputManager's allowed");
        InputManager.instance = this;
    }

    protected override void Update()
    {
        base.Update();
        this.GetMoveVector();
    }

    protected virtual void GetMoveVector()
    {
        this.horizontalInput = Input.GetAxisRaw("Horizontal");
    }
}
