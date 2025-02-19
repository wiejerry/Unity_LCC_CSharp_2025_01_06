using Jerry.Tools;
using UnityEngine;
using System;

namespace Jerry
{
    /// <summary>
    /// 資料類型轉換
    /// </summary>
    public class Class_9_2_DataTypeSwitch : MonoBehaviour 
    {
        private void Awake()
        {
            
        }

        private void Start()
        {
            // 將整數轉為字串
            int count = 99;
            var intToString = Convert.ToString(count);
            LogSystem.LogWithColor(intToString.GetType(), "#f96");
            // 將布林值轉為字串
            bool isOver = false;
            var boolToString = Convert.ToString(isOver);
            LogSystem.LogWithColor(boolToString.GetType(), "#f96");

            float move = 3.5f;
            var floatToByte = Convert.ToByte(move);
            LogSystem.LogWithColor(floatToByte, "#f96");
            LogSystem.LogWithColor(floatToByte.GetType(), "#f96");

            // trun = 1,false = 0
            bool isGrounded = true;
            var boolToByte = Convert.ToByte(isGrounded);
            LogSystem.LogWithColor(boolToString, "#6f6");
            LogSystem.LogWithColor(boolToString.GetType(), "#6f6");
        }

    }
}
