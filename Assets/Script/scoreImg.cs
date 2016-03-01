using UnityEngine;
using System.Collections;

public class scoreImg : MonoBehaviour {

    private Transform img;

    private float tempSizeZ ;
    private float tempSizeY;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 0.91f);
        img = GetComponent<Transform>();
        tempSizeZ = -6.98f;
        tempSizeY = 5.23f;

    }
	
	// Update is called once per frame
	void Update () {
        img.position = new Vector3(8f, tempSizeY, tempSizeZ);
        
        tempSizeZ -= 0.04f;
        tempSizeY += 0.02f;
        

        
    }
}
