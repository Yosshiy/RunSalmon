using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Playerの動き
/// </summary>
public class Player : MonoBehaviour
{
    //上下するスピード
    [SerializeField]float UpDownSpeed;
    //動ける範囲
    [SerializeField] float MaxValue;
    //今の位置
    float Value;

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Up(Time.deltaTime * UpDownSpeed);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            Down(Time.deltaTime * UpDownSpeed);
        }

    }

    /// <summary>
    /// 上方向に移動
    /// </summary>
    public void Up(float upvalue)
    {
        transform.position += new Vector3(0,upvalue,0);
        var upposition =  Mathf.Min(transform.position.y,MaxValue);
        transform.position = new Vector3(transform.position.x,upposition,transform.position.z);
    }

    /// <summary>
    /// 下方向に移動
    /// </summary>
    public void Down(float downvalue)
    {
        transform.position -= new Vector3(0, downvalue, 0);
        var downposition = Mathf.Max(transform.position.y, -MaxValue);
        transform.position = new Vector3(transform.position.x, downposition, transform.position.z);
    }

}
