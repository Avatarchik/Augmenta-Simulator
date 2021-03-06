﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSCManagerControllable : Controllable
{
    [Header("YO VERSION")]
    [OSCProperty(isInteractible = false)] public int yoVersion;
    [OSCProperty(isInteractible = false)] public int yoPort;

    [Header("OUTPUT SETTINGS")]
    [OSCProperty]
    public int outputPort;
    [OSCProperty]
    public string outputIP;
    [OSCProperty]
    [Tooltip("Time in s before a connection without heartbeat is deleted. 0 = Never.")]
    public float connectionTimeout;
}
