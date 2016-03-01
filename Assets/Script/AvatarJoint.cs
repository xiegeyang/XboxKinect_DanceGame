using UnityEngine;
using System.Collections;

public class AvatarJoint : MonoBehaviour {
    public GameObject linesFather;

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


    private LineRenderer[] lines;
    
    

    // Use this for initialization
    void Start () {
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

        lines = linesFather.GetComponentsInChildren<LineRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        for (int i = 0; i < humanBodyBones.Length; i++)
        {
            int offSet = 1;
            Vector3 tempPos = new Vector3(ani.GetBoneTransform(humanBodyBones[i]).position.x, ani.GetBoneTransform(humanBodyBones[i]).position.y, ani.GetBoneTransform(humanBodyBones[i]).position.z+offSet);

            jointPos[i] = tempPos;
            //line[i] = GetComponent<LineRenderer>();
            lines[i].SetWidth(.01f, .01f);
        }

        //leftFootTra = ani.GetBoneTransform(LeftFoot).position;
        //leftHandTra = ani.GetBoneTransform(LeftHand).position;
        //rightHandTra = ani.GetBoneTransform(RightHand).position;
        //line.SetWidth(.01f, .01f);
        //line.SetPosition(0, leftHandTra);
        //line.SetPosition(1, rightHandTra);
        // line.SetPosition(2, leftFootTra);
        //line0.SetWidth(.01f, .01f);

        ShowAllBones();
        
    }

    public void ShowAllBones()
    {
        lines[0].SetPosition(0, jointPos[6]);
        lines[0].SetPosition(1, jointPos[5]);
        //line1.SetWidth(.01f, .01f);
        lines[1].SetPosition(0, jointPos[5]);
        lines[1].SetPosition(1, jointPos[4]);
        //line2.SetWidth(.01f, .01f);
        lines[2].SetPosition(0, jointPos[4]);
        lines[2].SetPosition(1, jointPos[3]);
        //line3.SetWidth(.01f, .01f);
        lines[3].SetPosition(0, jointPos[3]);
        lines[3].SetPosition(1, jointPos[2]);
        //line4.SetWidth(.01f, .01f);
        lines[4].SetPosition(0, jointPos[2]);
        lines[4].SetPosition(1, jointPos[1]);
        //line5.SetWidth(0.01f, .01f);
        lines[5].SetPosition(0, jointPos[1]);
        lines[5].SetPosition(1, jointPos[0]);
        //line6.SetWidth(0.01f, .01f);
        lines[6].SetPosition(0, jointPos[10]);
        lines[6].SetPosition(1, jointPos[9]);
        //line7.SetWidth(0.01f, .01f);
        lines[7].SetPosition(0, jointPos[9]);
        lines[7].SetPosition(1, jointPos[8]);
        //line8.SetWidth(0.01f, .01f);
        lines[8].SetPosition(0, jointPos[8]);
        lines[8].SetPosition(1, jointPos[7]);
        //line9.SetWidth(0.01f, .01f);
        lines[9].SetPosition(0, jointPos[7]);
        lines[9].SetPosition(1, jointPos[2]);
        //line10.SetWidth(0.01f, .01f);
        lines[10].SetPosition(0, jointPos[11]);
        lines[10].SetPosition(1, jointPos[0]);
        //line11.SetWidth(0.01f, .01f);
        lines[11].SetPosition(0, jointPos[12]);
        lines[11].SetPosition(1, jointPos[11]);
        //line12.SetWidth(0.01f, .01f);
        lines[12].SetPosition(0, jointPos[13]);
        lines[12].SetPosition(1, jointPos[12]);
        //line13.SetWidth(0.01f, .01f);
        lines[13].SetPosition(0, jointPos[14]);
        lines[13].SetPosition(1, jointPos[13]);
        //line14.SetWidth(0.01f, .01f);
        lines[14].SetPosition(0, jointPos[15]);
        lines[14].SetPosition(1, jointPos[0]);
        //line15.SetWidth(0.01f, .01f);
        lines[15].SetPosition(0, jointPos[16]);
        lines[15].SetPosition(1, jointPos[15]);
        //line16.SetWidth(0.01f, .01f);
        lines[16].SetPosition(0, jointPos[17]);
        lines[16].SetPosition(1, jointPos[16]);
        //line17.SetWidth(0.01f, .01f);
        lines[17].SetPosition(0, jointPos[18]);
        lines[17].SetPosition(1, jointPos[17]);
        //line18.SetWidth(0.01f, .01f);
        lines[18].SetPosition(0, jointPos[19]);
        lines[18].SetPosition(1, jointPos[20]);
        //line19.SetWidth(0.01f, .01f);
        lines[19].SetPosition(0, jointPos[20]);
        lines[19].SetPosition(1, jointPos[3]);
        //line20.SetWidth(0.01f, .01f);
        lines[20].SetPosition(0, jointPos[20]);
        lines[20].SetPosition(1, jointPos[7]);
        //line21.SetWidth(.01f, .01f);
        lines[21].SetPosition(0, jointPos[21]);
        lines[21].SetPosition(1, jointPos[6]);
        // line22.SetWidth(.01f, .01f);
        lines[22].SetPosition(0, jointPos[22]);
        lines[22].SetPosition(1, jointPos[6]);
        //line23.SetWidth(.01f, .01f);
        lines[23].SetPosition(0, jointPos[23]);
        lines[23].SetPosition(1, jointPos[10]);
        //line24.SetWidth(.01f, .01f);
        lines[24].SetPosition(0, jointPos[24]);
        lines[24].SetPosition(1, jointPos[10]);
    }
    
}
