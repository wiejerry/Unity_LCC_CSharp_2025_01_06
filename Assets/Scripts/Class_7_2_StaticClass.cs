﻿using UnityEngine;

namespace Jerry
{
    /// <summary>
    /// 靜態類別
    /// 靜態類別不能繼承 MonoBehaviour ， 不能放在 Unity 的物件上
    /// </summary>
    public static class Class_7_2_StaticClass
    {
        // 常數 (靜態)
        // 常數是無法修改的，並且需要有預設值
        public const string playerName = "Jerry";
        // 靜態可以修改，也不用給予預設值
        public static string platerWeapon;

       // 靜態類別內只能有靜態成員
        public static int lv = 1;
        public static float speed => 500;

        public static void Run()
        {

        }

        // 靜態類別內不能有非靜態成員
        // public static int lv = 1;
        // public static float speed => 500;

        // public void walk()
        // {

        // } 
    }
}
