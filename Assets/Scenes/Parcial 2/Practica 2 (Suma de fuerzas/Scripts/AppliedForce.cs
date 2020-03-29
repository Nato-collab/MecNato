using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppliedForce : MonoBehaviour
{
    Vector3 newPos = new Vector3(0, 0, 0);
    public Text robotTeam;
    public Text ninjaTeam;
    public int robotTeamN = 0;
    public int ninjaTeamN = 0;

    void Start()
    {
        newPos = gameObject.transform.position;
        ninjaTeam.text = ("Ninja team force: " + ninjaTeamN + "N");
        robotTeam.text = ("Robot team force: " + robotTeamN + "N");
    }

    public void OnClickRight()
    {
        ninjaTeamN++;
        newPos.x += .2f;
        gameObject.transform.position = newPos;
        ninjaTeam.text = ("Ninja team force: " + ninjaTeamN + "N");
    }

    public void OnClickLeft()
    {
        robotTeamN++;
        newPos.x -= .2f;
        gameObject.transform.position = newPos;
        robotTeam.text = ("Robot team force: " + robotTeamN + "N");
    }
}
