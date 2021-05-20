using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCVehicleEntity : MonoBehaviour
{
    public bool willDrift;
    public bool obeysStoplights;
    public bool obeysSpeedLimits;
    public bool willChasePlayer;
    int recklessness;

    Vector3 startLoc;
    Vector3 desLoc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This seems sketch but we'll figure that out later
        navigate();
    }

    //Navigates
    void navigate()
    {
        /* If(crash) {
         *     don't()
         * }
         * 
         * Or more, like, figure out where to drive?
         */
    }
}
