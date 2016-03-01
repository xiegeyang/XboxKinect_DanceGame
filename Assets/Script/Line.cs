using UnityEngine;
using System.Collections;


public class Line : MonoBehaviour {

    public LineRenderer newLine;
    public GameObject danceModel;
    public GameObject player;

    public GameObject danceMode2;
    public GameObject player2;




    // Use this for initialization
    void Start () {

        
        

        
    }
	
	// Update is called once per frame
	void Update () {
       
        setLine(newLine);
       
	}

    Vector3 getPosition(GameObject model)
    {
        Vector3 position = model.transform.position;
        return position;

    }

    void setLine(LineRenderer line)
    {

        Vector3 modelpo1 = getPosition(danceModel);
        Vector3 modelpo2= getPosition(danceMode2);
        Vector3 playerpo = getPosition(player);
        Vector3 playerpo2 = getPosition(player2);

        Vector3 mode_vec = modelpo1 - modelpo2;
        Vector3 player_vec = playerpo - playerpo2;

        Vector3 displacement = player_vec - mode_vec;



        newLine.SetWidth(.01f, .01f);
        newLine.SetPosition(0, playerpo - displacement);
        newLine.SetPosition(1, playerpo);
    }
}
