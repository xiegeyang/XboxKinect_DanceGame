using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//[RequireComponent(typeof(HumanBones))]
public class SetAllLines : MonoBehaviour {
    public GameObject linesFather;

    public float offSetX = 0;
    public float offSetY = 0;
    public float offSetZ = 0;

    public bool showUpperBody = false;
    public bool showLowerBody = false;


    private LineRenderer[] lines;

    private Dictionary<int, LineRenderer> lineDic;

   // private List<LineRenderer> lineList;
    // Use this for initialization
    private float a = .01f;
    private float b = .01f;

    Vector3[] jointPos;

    HumanBones humanBones;

    


    
    void Start () {
        //lines = linesFather.GetComponentsInChildren<LineRenderer>();
        //linesFather = GetComponent<GameObject>();
        //lineList = new List<LineRenderer>();
        humanBones = GetComponent<HumanBones>();
        lineDic = new Dictionary<int, LineRenderer>();

        lines = linesFather.GetComponentsInChildren<LineRenderer>();

        for (int i = 0; i < lines.Length; i++)
        {
            //lines[i].SetWidth(a, b);
            //lineList.Add(lines[i]);
            lineDic.Add(i, lines[i]);
            
        }
        jointPos = new Vector3[25];
        
        
    }

	// Update is called once per frame
	void Update () {
        humanBones.SetOffSet(offSetX, offSetY, offSetZ);
        //ShowUpperBody(showUpperBody);
        //ShowLowerBody(showLowerBody);
        if (!ShowUpperBody(showUpperBody) && !ShowLowerBody(showLowerBody))
        {
            SetBones();
        }
        
        ShowALLBones();
        

    }

    public void SetBones()
    {
        for (int i = 0; i < lines.Length; i++)
        {
            lineDic[i].SetWidth(a, b);
        }
    }

    

    public void getBonesPos(Vector3[] _jointPos)
    {
        jointPos = _jointPos;
    }

    public void ShowALLBones()
    {   
        
        lineDic[0].SetPosition(0, jointPos[6]);
        lineDic[0].SetPosition(1, jointPos[5]);
        //line1.SetWidth(.01f, .01f);
        lineDic[1].SetPosition(0, jointPos[5]);
        lineDic[1].SetPosition(1, jointPos[4]);
        //line2.SetWidth(.01f, .01f);
        lineDic[2].SetPosition(0, jointPos[4]);
        lineDic[2].SetPosition(1, jointPos[3]);
        //line3.SetWidth(.01f, .01f);
        lineDic[3].SetPosition(0, jointPos[3]);
        lineDic[3].SetPosition(1, jointPos[2]);
        //line4.SetWidth(.01f, .01f);
        lineDic[4].SetPosition(0, jointPos[2]);
        lineDic[4].SetPosition(1, jointPos[1]);
        //line5.SetWidth(0.01f, .01f);
        lineDic[5].SetPosition(0, jointPos[1]);
        lineDic[5].SetPosition(1, jointPos[0]);
        //line6.SetWidth(0.01f, .01f);
        lineDic[6].SetPosition(0, jointPos[10]);
        lineDic[6].SetPosition(1, jointPos[9]);
        //line7.SetWidth(0.01f, .01f);
        lineDic[7].SetPosition(0, jointPos[9]);
        lineDic[7].SetPosition(1, jointPos[8]);
        //line8.SetWidth(0.01f, .01f);
        lineDic[8].SetPosition(0, jointPos[8]);
        lineDic[8].SetPosition(1, jointPos[7]);
        //line9.SetWidth(0.01f, .01f);
        lineDic[9].SetPosition(0, jointPos[7]);
        lineDic[9].SetPosition(1, jointPos[2]);
        //line10.SetWidth(0.01f, .01f);
        lineDic[10].SetPosition(0, jointPos[11]);
        lineDic[10].SetPosition(1, jointPos[0]);
        //line11.SetWidth(0.01f, .01f);
        lineDic[11].SetPosition(0, jointPos[12]);
        lineDic[11].SetPosition(1, jointPos[11]);
        //line12.SetWidth(0.01f, .01f);
        lineDic[12].SetPosition(0, jointPos[13]);
        lineDic[12].SetPosition(1, jointPos[12]);
        //line13.SetWidth(0.01f, .01f);
        lineDic[13].SetPosition(0, jointPos[14]);
        lineDic[13].SetPosition(1, jointPos[13]);
        //line14.SetWidth(0.01f, .01f);
        lineDic[14].SetPosition(0, jointPos[15]);
        lineDic[14].SetPosition(1, jointPos[0]);
        //line15.SetWidth(0.01f, .01f);
        lineDic[15].SetPosition(0, jointPos[16]);
        lineDic[15].SetPosition(1, jointPos[15]);
        //line16.SetWidth(0.01f, .01f);
        lineDic[16].SetPosition(0, jointPos[17]);
        lineDic[16].SetPosition(1, jointPos[16]);
        //line17.SetWidth(0.01f, .01f);
        lineDic[17].SetPosition(0, jointPos[18]);
        lineDic[17].SetPosition(1, jointPos[17]);
        //line18.SetWidth(0.01f, .01f);
        lineDic[18].SetPosition(0, jointPos[19]);
        lineDic[18].SetPosition(1, jointPos[20]);
        //line19.SetWidth(0.01f, .01f);
        lineDic[19].SetPosition(0, jointPos[20]);
        lineDic[19].SetPosition(1, jointPos[3]);
        //line20.SetWidth(0.01f, .01f);
        lineDic[20].SetPosition(0, jointPos[20]);
        lineDic[20].SetPosition(1, jointPos[7]);
        //line21.SetWidth(.01f, .01f);
        lineDic[21].SetPosition(0, jointPos[21]);
        lineDic[21].SetPosition(1, jointPos[6]);
        // line22.SetWidth(.01f, .01f);
        lineDic[22].SetPosition(0, jointPos[22]);
        lineDic[22].SetPosition(1, jointPos[6]);
        //line23.SetWidth(.01f, .01f);
        lineDic[23].SetPosition(0, jointPos[23]);
        lineDic[23].SetPosition(1, jointPos[10]);
        //line24.SetWidth(.01f, .01f);
        lineDic[24].SetPosition(0, jointPos[24]);
        lineDic[24].SetPosition(1, jointPos[10]);
    }

    public bool ShowUpperBody(bool _ShowUpperBody)
    {
        
        if (_ShowUpperBody)
        {
            //SetBones();
            
            lineDic[17].SetWidth(0, 0);
            lineDic[16].SetWidth(0, 0);
            lineDic[15].SetWidth(0, 0);
            lineDic[14].SetWidth(0, 0);
            lineDic[13].SetWidth(0, 0);
            lineDic[12].SetWidth(0, 0);
            lineDic[11].SetWidth(0, 0);
            lineDic[10].SetWidth(0, 0);
            

        }
        return _ShowUpperBody;
    }

    public bool ShowLowerBody(bool _ShowLowerBody)
    {
        
        if (_ShowLowerBody)
        {
            //SetBones();

            lineDic[0].SetWidth(0, 0);
            lineDic[1].SetWidth(0, 0);
            lineDic[2].SetWidth(0, 0);
            lineDic[3].SetWidth(0, 0);
            lineDic[9].SetWidth(0, 0);
            lineDic[8].SetWidth(0, 0);
            lineDic[7].SetWidth(0, 0);
            lineDic[6].SetWidth(0, 0);
            lineDic[21].SetWidth(0, 0);
            lineDic[22].SetWidth(0, 0);
            lineDic[23].SetWidth(0, 0);
            lineDic[24].SetWidth(0, 0);
            lineDic[18].SetWidth(0, 0);
            lineDic[19].SetWidth(0, 0);
            lineDic[20].SetWidth(0, 0);

        }
        return _ShowLowerBody;
    }



}
