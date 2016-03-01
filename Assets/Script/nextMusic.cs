using UnityEngine;
using System.Collections;

public class nextMusic : MonoBehaviour {

    private CubeGestureListener gesTureListener;
    public Animator anim1;
    private Animator anim;
    public int x = 3;
    public AudioClip audioClip0;
    public AudioClip audioClip1;
    public AudioClip audioClip2;
    public AudioClip audioClip3;

    private AudioSource audioSource;


	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        gesTureListener = CubeGestureListener.Instance;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0) || gesTureListener.IsSwipeRight())
        {
            x++;
            if (x % 4 == 0)
            {
                anim.Play("nextMusic0", -1, 0f);
                audioSource.clip = audioClip1;
                audioSource.Play();
                anim1.Play("dance1", -1, 0f);
            }
            else if (x % 4 == 1)
            {
                anim.Play("nextMusic1", -1, 0f);
                audioSource.clip = audioClip2;
                audioSource.Play();
                anim1.Play("dance2", -1, 0f);
            }
            else if (x % 4 == 2)
            {
                anim.Play("nextMusic2", -1, 0f);
                audioSource.clip = audioClip3;
                audioSource.Play();
                anim1.Play("dance3", -1, 0f);
            }
            else if (x % 4 == 3)
            {
                anim.Play("nextMusic3", -1, 0f);
                audioSource.clip = audioClip0;
                audioSource.Play();
                anim1.Play("dance4", -1, 0f);
            }
        }
        else if (gesTureListener.IsPush())
        {
            Application.LoadLevel("playSwift");
        }
        

        
	}
}
