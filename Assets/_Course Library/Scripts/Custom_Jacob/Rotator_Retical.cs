using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator_Retical : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 3, 0, Space.World);

    }
}
