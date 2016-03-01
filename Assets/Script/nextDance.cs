using UnityEngine;
using System.Collections;

public class nextDance : MonoBehaviour {

    private CubeGestureListener gestureListener;
    private Animator anim;

    public int x = 3;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        gestureListener = CubeGestureListener.Instance;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)||gestureListener.IsSwipeRight())
        {
            x++;
            if (x % 4 == 0)
            {
                anim.Play("dance1", -1, 0f);
            }
            else if (x % 4 == 1)
            {
                anim.Play("dance2", -1, 0f);
            }
            else if (x % 4 == 2)
            {
                anim.Play("dance3", -1, 0f);
            }
            else if (x % 4 == 3)
            {
                anim.Play("dance4", -1, 0f);
            }

        }
	}
}
