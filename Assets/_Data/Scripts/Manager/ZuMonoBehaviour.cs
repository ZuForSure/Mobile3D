using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZuMonoBehaviour : MonoBehaviour
{
    protected virtual void Awake()
    {
        this.LoadComponent();
        this.ResetValue();
    }

    protected virtual void Reset()
    {
        this.LoadComponent();
        this.ResetValue();
    }

    protected virtual void Start()
    {
        //For override
    }

    protected virtual void Update()
    {
        //For override
    }

    protected virtual void LoadComponent()
    {
        //For override
    }

    protected virtual void ResetValue()
    {
        //For override
    }
}
