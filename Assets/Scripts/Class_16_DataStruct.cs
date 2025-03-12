using Jerry.Tools;
using UnityEngine;
using System.Collections.Generic;

namespace Jerry.Class_16
{
    /// <summary>
    /// 資料結構
    /// </summary>
    public class Class_16_DataStruct : MonoBehaviour
    {
        #region 清單
        // 陣列
        public int[] attacks = { 10, 15, 7 };
        public float[] defens = { 1.5f, 7.5f, 0.3f };

        // 清單 : 泛型集合
        public List<int> speeds = new List<int>() { 3, 9, 7 };
        public List<string> props = new List<string>() { "藥水", "地圖" };
        public List<float> playerDefens;
        #endregion

        private void Awake()
        {
            #region 清單
            // 清單存取 : 與陣列相同
            LogSystem.LogWithColor($"第三筆速度 : {speeds[2]}", "#3f3");
            speeds[0] = 10;
            LogSystem.LogWithColor($"第一筆速度 : {speeds[0]}", "#3f3");

            // 添加一筆道具
            props.Add("寶劍");
            // 刪除第一筆道具
            props.RemoveAt(0);
            // 添加頭盔到編號 1 上
            props.Insert(1, "頭盔");

            foreach (var prop in props)
            {
                LogSystem.LogWithColor($"道具 : {prop}", "#f93");
            }

            // 使用建構子帶入陣列
            playerDefens = new List<float>(defens);
            // 排序，由小到大
            playerDefens.Sort();
            // 反排序，由大到小
            playerDefens.Reverse();

            foreach (var item in playerDefens)
            {
                LogSystem.LogWithColor($"資料 : {item}", "#f93");
            }

            // Count 指清單內的資料，根據 Add 或 Remove 改變
            LogSystem.LogWithColor($"數量 : {props.Count}", "#77f");
            // Capacity 指清單內的容量，系統自動分配，預設為 4 並且以倍數成長 (C# 各版本不同)
            LogSystem.LogWithColor($"容量 : {props.Capacity}", "#77f");

            List<int> numbers = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i);
                LogSystem.LogWithColor($"數量 : {numbers.Count}", "#3a3");
                LogSystem.LogWithColor($"容量 : {numbers.Capacity}", "#f39");
            }
            #endregion

            // 堆疊 : 先進後出， 類似椅子堆疊在一起
            Stack<string> enemys = new Stack<string>();
            // 放資料進入堆疊
            enemys.Push("史萊姆");
            enemys.Push("哥布林");
            LogStack<string>(enemys);
        }

        private void LogStack<T>(Stack<T> stack)
        {
            foreach (var item in stack)
            {               
                LogSystem.LogWithColor($"堆疊資料 : {item}", "#f77");
            }
        }
    }
}
