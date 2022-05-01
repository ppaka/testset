using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedChanger : MonoBehaviour
{
    public AnimationCurve curve;
    [TextArea]public string value;

    public float time, maxTime;
    public Transform cube;
    
    private void Start()
    {
        var lines = value.Split("\n");
        foreach (var line in lines)
        {
            var ch = line.Split(' ');
            var kf = new Keyframe(float.Parse(ch[0]), float.Parse(ch[1]), float.PositiveInfinity, float.PositiveInfinity);
            curve.AddKey(kf);
        }
    }

    private void Update()
    {
        time += Time.deltaTime;
        var ev = curve.Evaluate(time);
        cube.transform.position = Vector3.LerpUnclamped(Vector3.zero, Vector3.up, ev);
    }
}
