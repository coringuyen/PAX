﻿using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Messenger.Broadcast("crouch");
        }
        else if (Input.GetKeyDown(KeyCode.Z))
            Messenger.Broadcast("prone");
    }

}



