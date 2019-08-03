using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBackGround : UIPanel {
    private GameObject UIBackGroundS;


    // Use this for initialization
   protected override void Start () {
        InitListener();
        InitViews();
    }
	
	// Update is called once per frame
	void Update () {
        UIBackGroundS.transform.Translate(Vector3.back*Time.deltaTime);
    }
    protected override void InitViews()
    {
        UIBackGroundS = GameObject.Find("UIBackGround").gameObject;
    }
    protected override void InitListener()
    {

    }
    
   
}
