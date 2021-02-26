using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitbtn : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Application.Quit();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void BtnExit()
    {
        //SSTools.ShowMessage("Exit", SSTools.Position.bottom, SSTools.Time.oneSecond);
        Application.Quit();
    }
}
