using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class UIPanel : MonoBehaviour {
    

    protected virtual void Start()
    {
        InitViews();
        InitListener();
    }

    protected abstract void InitViews();

    protected abstract void InitListener();
}
