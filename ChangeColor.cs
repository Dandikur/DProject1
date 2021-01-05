using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject targete;
    public string milihe;

    void OnMouseUp()
    {
        if(milihe == "1")
        {
            targete.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
        }
        else if(milihe == "2")
        {
            targete.GetComponent<Renderer>().material.color = new Color(255, 198, 198);
        }
        else if(milihe == "3")
        {
            targete.GetComponent<Renderer>().material.color = new Color(253, 120, 120);
        }
        else if (milihe == "4")
        {
            targete.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
        }
    }
}
