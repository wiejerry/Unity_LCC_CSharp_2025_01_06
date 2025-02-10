using UnityEngine;

namespace Jerry
{
    /// <summary>
    /// 練習存取資料用
    /// </summary>
    public class Class_7_1_GetSetDate : MonoBehaviour
    {
        public Class_7_1_Property Property;
        
        private void Awake()
        {
            // 取得另一個類別的資料
            Debug.Log(Property.moveSpeed);      // 可以取得公開變數
            // Debug.Log(Property.turnSpeed);   // 不可去得私人變數

            // 設定另一個類別的資料
            Property.moveSpeed = 7.7f;          // 可以取得公開變數
            // Property.turnSpeed = 20.2f;      // 不可去得私人變數

            Debug.Log(Property.runSpeed);       //可以取得公開變數
            // Debug.Log(Property.sprintSpeed); //不可去得私人變數

            Property.runSpeed = 50.3f;          // 可以設定有 set 的屬性
            // Property.jumpSpeed = 99.5f;      // 不可設定沒有 set 的屬性(唯獨)
        }
    }
}