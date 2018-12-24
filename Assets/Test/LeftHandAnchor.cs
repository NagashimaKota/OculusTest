using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftHandAnchor : MonoBehaviour {

    public BulletMove bulletGenelate;

    private bool t = false;

	void Start () {
		
	}
	
	

	void Update () {
        if (OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger))
        {
            Debug.Log("左人差し指トリガーを押した");
            if (t == false)
            {
                t = true;
            }
            else
            {
                t = false;
            }
        }

        if (t)
        {
            bulletGenelate.Genelat();
        }
    }
}
