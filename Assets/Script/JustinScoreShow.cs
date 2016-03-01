using UnityEngine;
using System.Collections;

public class JustinScoreShow : MonoBehaviour {

    //private CubeGestureListenerForJustin gestureListener;

    public GUIText scoreShow;

    //public GUIText charx;
    //public GUIText playx;
    
    public float waveWait = 2f;

    public Animator player;
    public Animator charactor;

    //private Vector3 rightHandVecGap;
    //private Vector3 leftHandVecGap;

    //private Vector3 rightFootVecGap;
    //private Vector3 leftFootVecGap;

    private float totalGapChar;
    private float totalGapPlay;


    private int goodScore = 10;
    private int greatScore = 30;
    private int perfectScore = 50;

    private float totalScore = 0;
    private float score = 0.7f;

    public Rigidbody goodImg;
    public Rigidbody greatImg;
    public Rigidbody perfectImg;

    private float tempSize;
    





    // Use this for initialization
    void Start () {
        //goodImg.transform.localScale = new Vector3(0, 0, 0);
        //greatImg.transform.localScale = new Vector3(0, 0, 0);
        

        StartCoroutine(ScoreAnim());
        
    }

    // Update is called once per frame
    void Update () {
        totalGapChar = getBonesVectoerGap(charactor);
        totalGapPlay = getBonesVectoerGap(player);

        score = 100 - (Mathf.Abs(totalGapPlay - totalGapChar) * 100);


        //perfectImg.transform.localScale = new Vector3(tempSize, tempSize, tempSize);
        if (tempSize > 0 && !(tempSize<0.5))
            tempSize -= .05f;


        //charx.text = charactor.GetBoneTransform(HumanBodyBones.RightHand).position.x.ToString();
        //playx.text = player.GetBoneTransform(HumanBodyBones.RightHand).position.x.ToString();
    }


    // Dance Action
    IEnumerator ScoreAnim()
    {
        for(int i=0; i < 100; i++)
        {
            yield return new WaitForSeconds(.91f);
            if(score >= 80)
            {
                Rigidbody newPerfectImg = Instantiate(perfectImg, new Vector3(8, 5.23f, -6.98f), new Quaternion(0, 180f, 0, 0)) as Rigidbody;
            }
            else if(score >= 60 && score < 80)
            {
                Rigidbody newGreatImg = Instantiate(greatImg, new Vector3(8, 5.23f, -6.98f), new Quaternion(0, 180f, 0, 0)) as Rigidbody;
            }else
            {
                
                Rigidbody newGoodImg = Instantiate(goodImg, new Vector3(8, 5.23f, -6.98f), new Quaternion(0, 180f, 0, 0)) as Rigidbody;
            }
            totalScore += score;
            scoreShow.text = totalScore.ToString();
        }
        
        
    }


    float getBonesVectoerGap(Animator _charactor)
    {
        float _rightHandVecGapX = Mathf.Abs(_charactor.GetBoneTransform(HumanBodyBones.RightHand).position.x - _charactor.GetBoneTransform(HumanBodyBones.Chest).position.x);
        float _leftHandVecGapX = Mathf.Abs(_charactor.GetBoneTransform(HumanBodyBones.LeftHand).position.x - _charactor.GetBoneTransform(HumanBodyBones.Chest).position.x);

        float _leftFootVecGapX = Mathf.Abs(_charactor.GetBoneTransform(HumanBodyBones.LeftFoot).position.x - _charactor.GetBoneTransform(HumanBodyBones.Chest).position.x);
        float _rightFootVecGapX = Mathf.Abs(_charactor.GetBoneTransform(HumanBodyBones.RightFoot).position.x - _charactor.GetBoneTransform(HumanBodyBones.Chest).position.x);

        float _rightHandVecGapY = Mathf.Abs(_charactor.GetBoneTransform(HumanBodyBones.RightHand).position.y - _charactor.GetBoneTransform(HumanBodyBones.Chest).position.y);
        float _leftHandVecGapY = Mathf.Abs(_charactor.GetBoneTransform(HumanBodyBones.LeftHand).position.y - _charactor.GetBoneTransform(HumanBodyBones.Chest).position.y);

        float _leftFootVecGapY = Mathf.Abs(_charactor.GetBoneTransform(HumanBodyBones.LeftFoot).position.y - _charactor.GetBoneTransform(HumanBodyBones.Chest).position.y);
        float _rightFootVecGapY = Mathf.Abs(_charactor.GetBoneTransform(HumanBodyBones.RightFoot).position.y - _charactor.GetBoneTransform(HumanBodyBones.Chest).position.y);


        float _totalGap = _rightHandVecGapX + _leftHandVecGapX + _leftFootVecGapX + _rightFootVecGapX + _rightHandVecGapY + _leftHandVecGapY + _leftFootVecGapY + _rightFootVecGapY;

        return _totalGap;


    }

   

}
