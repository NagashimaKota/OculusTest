using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightHandAnchor : MonoBehaviour {

    public BulletMove bulletGenelate;
    private bool t = false;

    void Start()
    {

    }
    
    void Update()
    {
        
        if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Debug.Log("右人差し指トリガーを押した");
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
