using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ViewSkeleton : MonoBehaviour
{
    public LineRenderer newLine;

    public Transform rootNode;
    public Transform[] childNodes;

    void Start()
    {
        if (rootNode != null)
        {
            if (childNodes == null)
            {
                //get all joints to draw
                PopulateChildren();
            }
        }

    }

    void Update()
    {
        setLine(newLine);
    }

    public void PopulateChildren()
    {
        childNodes = rootNode.GetComponentsInChildren<Transform>();
    }

    void setLine(LineRenderer line)
    {

        if (rootNode != null)
        {
            if (childNodes == null)
            {



                foreach (Transform child in childNodes)
                {

                    newLine.SetWidth(.01f, .01f);
                    newLine.SetPosition(0, child.position);
                    newLine.SetPosition(1, child.parent.position);

                  
                }

            }
        }
    }

 }
