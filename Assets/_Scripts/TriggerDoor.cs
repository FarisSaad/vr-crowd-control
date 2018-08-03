using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : MonoBehaviour {

    public Animator anim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //do some stuff
            anim.SetTrigger("open");
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            //do some stuff
            anim.SetTrigger("close");
        }
    }
}
