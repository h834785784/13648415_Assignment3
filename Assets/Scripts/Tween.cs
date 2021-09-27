using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween
{
    public Transform Target { get; private set; }
    public Vector3 StartPos { get; private set; }
    public Vector3 Destin { get; private set; }
    public float StartTime { get; private set; }
    public float Duration { get; private set; }



    public Tween(Transform targetObject, Vector3 startPos, Vector3 endPos, float startTime, float duration)

    {
        Target = targetObject;
        StartPos = startPos;
        Destin = endPos;
        StartTime = startTime;
        Duration = duration;

    }
}