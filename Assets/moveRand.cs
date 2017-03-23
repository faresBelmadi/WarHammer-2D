using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveRand : MonoBehaviour {

    Behaviour HaloRange;
	// Use this for initialization
	void Start () {
        HaloRange = (Behaviour)GetComponent("Halo");
        
    }
	
	// Update is called once per frame
	void Update () {
	}

    private void OnMouseDown()
    {
        if (HaloRange.enabled)
            HaloRange.enabled = false;
        else
            HaloRange.enabled = true;
    }
}
