using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine;

public static class ExtensionMethods
{
    public static bool Between<T>(this T value, T min, T max) where T : IComparable<T>
    {
        return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
    }
}
public class xiaochedate : MonoBehaviour
{
    public int totalwending = 0, totalweight = 0,score;
    public Text text3;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
   public  void jugdement()
    {
        if (totalweight.Between(20,30))
        {
            if(totalwending.Between(10,20))
            {
                score = 52;
                text3.text = "稳定性较低，重量太轻，还请加油";
            }
            if (totalwending.Between(20, 30))
            {
                score = 60;
                text3.text = "已经合格了，但是还是太轻了";
            }
            if (totalwending.Between(30, 40))
            {
                score = 73;
                text3.text = "稳定性很好啦，重量方面还要再考虑考虑";
            }
        }
        if (totalweight.Between(30, 40))
        {
            if (totalwending.Between(10, 20))
            {
                score = 61;
                text3.text = "已经合格啦，但是稳定性不够好";
            }
            if (totalwending.Between(20, 30))
            {
                score = 87;
                text3.text = "做的很棒，要是稳定性再好一点就完美了";
            }
            if (totalwending.Between(30, 40))
            {
                score = 100;
                text3.text = "完美，无可挑剔！";
            }
        }
        if (totalweight.Between(40, 50))
        {
            if (totalwending.Between(10, 20))
            {
                score = 70;
                text3.text = "太重啦，稳定性也还不够好";
            }
            if (totalwending.Between(20, 30))
            {
                score = 84;
                text3.text = "做的不错，但是重量还可以再轻一点";
            }
            if (totalwending.Between(30, 40))
            {
                score = 65;
                text3.text = "太笨重啦，试着用用塑料材质吧";
            }
        }
    }
}

