using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPenBook : MonoBehaviour
{

    public GameObject Cover;
    public HingeJoint myHinge;

    // Start is called before the first frame update
    void Start()
    {
        var myHinge = Cover.GetComponent<HingeJoint>();
        myHinge.useMotor = false;

    }

    // Update is called once per frame
    public void OpenBook()

    {
        myHinge.useMotor = true;
        Debug.Log("motor should be true");
    }
    public void CloseBook()

    {
        myHinge.useMotor = false;
        Debug.Log("motor should be false");
    }

}
