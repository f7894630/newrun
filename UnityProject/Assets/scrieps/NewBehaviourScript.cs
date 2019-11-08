using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("speed")][Range(0f,100f)]
    public float speed = 3.5f;
    [Header("jump")][Range(100,2000)]
    public int jump = 300;
    [Header("standornot")][Tooltip("判斷角色是否在陸地")]
    public bool isGround = false;
    [Header("name")]
    public string name = "YEE";
}
