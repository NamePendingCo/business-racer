using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVehicleEnity : VehicleEntity
{

    public int playerID;
    public Vector3 startLoc;
    public Vector3 desLoc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // on appropriate keybinds, runs the appropriate movement methods
        // probably should have meeting to discuss keybinds
    }
}
