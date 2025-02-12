﻿using UnityEngine;

namespace Jerry
{ 
    /// <summary>
    /// 類別 Class
    /// </summary>
    public class Class_8_1_Class : MonoBehaviour
    {
        // 類別 :
        // 用來定義一個物件以及他所擁有的資料與功能 (成員)

        private void Awake()
        {
            // 實力化 NPC 並儲存在 npcJack 變數內
            Class_8_1_NPC npcJack = new Class_8_1_NPC("傑克");
            Class_8_1_NPC npcJerry = new Class_8_1_NPC("Jerry","你好啊~");

            npcJack.LogName();
            npcJerry.LogName();
            npcJack.Talk();
            npcJerry.Talk();
        }
    }
}
