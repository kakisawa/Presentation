using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float swingAngle = 30.0f; // 揺れる角度
    public float swingSpeed = 1.0f;  // 揺れる速度

    private float initialRotation;   // 初期の回転角度


    void Start()
    {
        initialRotation = transform.eulerAngles.z;   // 現在のz軸の角度を取得 
    }


    void Update()
    {
       float rotationZ = initialRotation + Mathf.Sin(Time.time * swingSpeed) * swingAngle;
       transform.eulerAngles = new Vector3(0, 0, rotationZ);
    }
   
}
