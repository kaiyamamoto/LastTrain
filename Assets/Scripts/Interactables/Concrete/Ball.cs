﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : GrabbableObject
{
    int useCount = 0;

    public override void OnControllerEnter(PlayerViveController currentController, PlayerViveController.HandSource handSource)
    {
    }

    public override void OnControllerExit()
    {
    }

    public override void OnControllerStay()
    {
    }

    public override void OnGrab()
    {
    }

    public override void OnGrabReleased(bool snapped)
    {
    }

    public override void OnUse()
    {
        Debug.Log("Used ball: " + (++useCount).ToString());


    }
}