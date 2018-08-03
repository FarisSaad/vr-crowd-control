using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOffset : MonoBehaviour {

    public Renderer rend;
    public Material mat;

    public float offset;

    // Use this for initialization
    void Start () {
        rend = gameObject.GetComponent<Renderer>();
        mat = rend.material;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //mat.mainTextureOffset = new Vector2(offset, 0);
        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
