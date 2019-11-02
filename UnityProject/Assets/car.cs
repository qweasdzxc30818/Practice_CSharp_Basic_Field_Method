using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class car : MonoBehaviour
{
    [Header("速度")]
    [Range(0,200)]
    public int speed;
    [Header("轉向速度")]
    [Range(0, 200)]
    public int speedTurn;
    [Header("檔次")]
    [Range(0,10)]
    public int carShift;
    [Header("汽車品牌")]
    public string bard="BMW";
    [Header("煞車")]
    public bool brakes;
    [Header("汽車變形元件")]
    public Transform Car;
    [Header("汽車顏色")]
    public Color Carcolor;
    public void CarForward()
    {
        Car.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    public void CarBack()
    {
        Car.Translate(Vector3.back * speed * Time.deltaTime);
    }
    public void Carleft()
    {
        Car.transform.Rotate(0 , -speedTurn * Time.deltaTime, 0);
    }
    public void Carright()
    {
        Car.transform.Rotate(0, speedTurn * Time.deltaTime, 0);
    }
    




    void Update()
    {
        
        
    }
}
