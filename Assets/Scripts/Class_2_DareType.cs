﻿using UnityEngine;

//三條斜線是摘要 (XML 語言) 用來做簡短說明，可加在類別與變數上方
/// <summary>
/// 認識資料類型
/// </summary>
public class Class_2_DareType : MonoBehaviour 
{
    //變數語法：
    //修飾詞 資料類型 愛數名稱 指定 預設值；
    //四大常用資料類型
    //整數：儲存沒有小數點的數值 int
    //浮點數：儲存有小數點的數值 float
    //字串：儲存文字，必須用雙引號 string
    //布林值：儲存正與反 boo1 只有兩種值 true 與 false
    public int count = 7;
    public float moveSpeed = 3.5f;         // 浮點數必須添加f 後綴
    public float turnSpeed = 30.7F;        // 大小F 皆可
    public string character = "蓋倫";
    public bool isDead = false;            // 是否死亡：否
    public bool gameOver = true;           // 是否結束：是

    //整理衣料類型
    public byte lv = 16;                   // byte 型別，範圍 0 ~ 255，大小 8 byte
    public uint coin = 9999;               // uint 型別，範圍 0 ~ 4***，大小 32 byte
    public long items = 3000;              // long 型別，範圍 0 ~ 92***，大小 64 byte

    //字串與字元
    public string playerName = "Jerry";    //字串:儲存多個字元，使用雙引號
    public char a = 'a';                   //字元:儲存一個字元，使用單引號

    //溢位
    //public sbyte number = 128;             //溢位導致錯誤，會出現紅色蚯蚓
}
