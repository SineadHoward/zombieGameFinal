using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Jimmy Vegas Unity Tutorial
//These scripts will create a raycast and open the door

public class PlayerCasting : MonoBehaviour
{

    public static float DistanceFromTarget;
    public float ToTarget;


    void Update()
    {
        RaycastHit Hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Hit))
        {
            ToTarget = Hit.distance;
            DistanceFromTarget = ToTarget;
        }
    }
}





//========================



