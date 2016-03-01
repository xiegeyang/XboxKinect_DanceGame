using UnityEngine;
using System.Collections;

public class DanceMotion : MonoBehaviour {
    private HumanBodyBones[] humanBodyBones;

    public Animator charactorAni;
    public Animator playerAni;
    public Animator newCharactorAni;

    private HumanBodyBones Hips;
    private HumanBodyBones Spine;
    private HumanBodyBones Chest;
    private HumanBodyBones LeftShoulder;
    private HumanBodyBones LeftUpperArm;
    private HumanBodyBones LeftLowerArm;
    private HumanBodyBones LeftHand;
    private HumanBodyBones RightShoulder;
    private HumanBodyBones RightUpperArm;
    private HumanBodyBones RightLowerArm;
    private HumanBodyBones RightHand;
    private HumanBodyBones LeftUpperLeg;
    private HumanBodyBones LeftLowerLeg;
    private HumanBodyBones LeftFoot;
    private HumanBodyBones LeftToes;
    private HumanBodyBones RightUpperLeg;
    private HumanBodyBones RightLowerLeg;
    private HumanBodyBones RightFoot;
    private HumanBodyBones RightToes;
    private HumanBodyBones Head;
    private HumanBodyBones Neck;
    private HumanBodyBones LeftThumbDistal;
    private HumanBodyBones LeftMiddleDistal;
    private HumanBodyBones RightThumbDistal;
    private HumanBodyBones RightMiddleDistal;

    private Vector3[] charactorPos;
    private Vector3[] playerPos;

    private Vector3[] newPlayerPos;
    private Vector3[] newCharactorPos;

    private Vector3 tempPos;

    //public GUIText playx;


    // Use this for initialization
    void Start () {
        

        Hips = HumanBodyBones.Hips;
        Spine = HumanBodyBones.Spine;
        Chest = HumanBodyBones.Chest;
        LeftShoulder = HumanBodyBones.LeftShoulder;
        LeftUpperArm = HumanBodyBones.LeftUpperArm;
        LeftLowerArm = HumanBodyBones.LeftLowerArm;
        LeftHand = HumanBodyBones.LeftHand;
        RightShoulder = HumanBodyBones.RightShoulder;
        RightUpperArm = HumanBodyBones.RightUpperArm;
        RightLowerArm = HumanBodyBones.RightLowerArm;
        RightHand = HumanBodyBones.RightHand;
        LeftUpperLeg = HumanBodyBones.LeftUpperLeg;
        LeftLowerLeg = HumanBodyBones.LeftLowerLeg;
        LeftFoot = HumanBodyBones.LeftFoot;
        LeftToes = HumanBodyBones.LeftToes;
        RightUpperLeg = HumanBodyBones.RightUpperLeg;
        RightLowerLeg = HumanBodyBones.RightLowerLeg;
        RightFoot = HumanBodyBones.RightFoot;
        RightToes = HumanBodyBones.RightToes;
        Head = HumanBodyBones.Head;
        Neck = HumanBodyBones.Neck;
        LeftThumbDistal = HumanBodyBones.LeftThumbDistal;
        LeftMiddleDistal = HumanBodyBones.LeftMiddleDistal;
        RightThumbDistal = HumanBodyBones.RightThumbDistal;
        RightMiddleDistal = HumanBodyBones.RightMiddleDistal;

        humanBodyBones = new HumanBodyBones[]{ Hips, Spine, Chest, LeftShoulder, LeftUpperArm, LeftLowerArm, LeftHand, RightShoulder, RightUpperArm, RightLowerArm, RightHand,
            LeftUpperLeg,LeftLowerLeg,LeftFoot,LeftToes,RightUpperLeg,RightLowerLeg,RightFoot,RightToes,Head,Neck,LeftThumbDistal,LeftMiddleDistal,RightThumbDistal,RightMiddleDistal};

        charactorPos = new Vector3[humanBodyBones.Length];
        playerPos = new Vector3[humanBodyBones.Length];
        newCharactorPos = new Vector3[humanBodyBones.Length];
        newPlayerPos = new Vector3[humanBodyBones.Length];



    }

    // Update is called once per frame
    void Update () {
        charactorPos = charPosition(charactorAni);
        playerPos = charPosition(playerAni);

        tempPos = charactorPos[2] - playerPos[2];

        //playx.text = tempPos.x.ToString();

        for(int i = 0; i < humanBodyBones.Length; i++)
        {
            newPlayerPos[i] = playerPos[i] + tempPos;
        }

        for(int i = 0; i < humanBodyBones.Length; i++)
        {
            newCharactorPos[i] = (newPlayerPos[i] + charactorPos[i]) / 2;
        }

        for (int i = 0; i < humanBodyBones.Length; i++)
        {
            newCharactorAni.GetBoneTransform(humanBodyBones[i]).position = newCharactorPos[i]  - new Vector3(-2f,0,-4);
        }
    }


    Vector3[] charPosition(Animator _animator)
    {

        Vector3[] jointPos = new Vector3[humanBodyBones.Length];

        for (int i = 0; i < humanBodyBones.Length; i++)
        {

            jointPos[i] = new Vector3(_animator.GetBoneTransform(humanBodyBones[i]).position.x, _animator.GetBoneTransform(humanBodyBones[i]).position.y
                , _animator.GetBoneTransform(humanBodyBones[i]).position.z);


            //line[i] = GetComponent<LineRenderer>();

        }

        return jointPos;
    }
}
