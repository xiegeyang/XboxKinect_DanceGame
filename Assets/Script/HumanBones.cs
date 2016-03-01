using UnityEngine;
using System.Collections;


//[RequireComponent(typeof(SetAllLines))]
public class HumanBones : MonoBehaviour {
   

    private HumanBodyBones[] humanBodyBones;


    private Animator ani;


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


    private Vector3[] jointPos;

    //private SetLines setLines;

    private SetAllLines allLines;
    //private GameObject linesFather;
    //private LineRenderer[] lines;

    private float _offSetX = 0;
    private float _offSetY = 0;
    private float _offSetZ = 0;




    // Use this for initialization
    void Start()
    {
        ani = GetComponent<Animator>();


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


        //line = new LineRenderer[humanBodyBones.Length];
        //for (int i = 0; i < humanBodyBones.Length; i++)
        //{
        //jointPos[i] = ani.GetBoneTransform(humanBodyBones[i]).position;
        //line[i] = GetComponent<LineRenderer>();
        //line[i].SetWidth(.01f, .01f);
        //}       

        jointPos = new Vector3[humanBodyBones.Length];

        //lines = allLines.getLinesFather().GetComponentsInParent<LineRenderer>();
        allLines = GetComponent<SetAllLines>();
        //allLines.SetAllLineWeith(.01f, .01f);
    }

    // Update is called once per frame
    void Update()
    {

        for (int i = 0; i < humanBodyBones.Length; i++)
        {
            
            Vector3 tempPos = new Vector3(ani.GetBoneTransform(humanBodyBones[i]).position.x + _offSetX, ani.GetBoneTransform(humanBodyBones[i]).position.y
                + _offSetY, ani.GetBoneTransform(humanBodyBones[i]).position.z + _offSetZ);

            jointPos[i] = tempPos;
            //line[i] = GetComponent<LineRenderer>();
           
        }

        //leftFootTra = ani.GetBoneTransform(LeftFoot).position;
        //leftHandTra = ani.GetBoneTransform(LeftHand).position;
        //rightHandTra = ani.GetBoneTransform(RightHand).position;
        //line.SetWidth(.01f, .01f);
        //line.SetPosition(0, leftHandTra);
        //line.SetPosition(1, rightHandTra);
        // line.SetPosition(2, leftFootTra);45
        //line0.SetWidth(.01f, .01f);
        
        allLines.getBonesPos(jointPos);

    }

    public void SetOffSet(float x, float y, float z)
    {
        _offSetX = x;
        _offSetY = y;
        _offSetZ = z;
    }

}
