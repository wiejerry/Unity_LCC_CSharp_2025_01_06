using UnityEngine;

namespace Jerry
{
    /// <summary>
    /// 練習取得與設定靜態資料
    /// </summary>
    public class Class_7_2_GetSetStaticData : MonoBehaviour
    {
        // 取得非靜態資料(成員)
        // 1. 先定義要獲得的資料類別的變數
        // 2. 透過變數取得非靜態資料(成員)
        public Class_7_2_Static Class_7_2;

        private void Awake()
        {
            // 變數名稱.非靜態成員
            // 取得靜態變數
            Debug.Log($"<color=#f3d>非靜態變數 : {Class_7_2.inventorywater}</color>");
            // 取得非靜態屬性
            Debug.Log($"<color=#f3d>非靜態屬性 : {Class_7_2.skillMain}</color>");
            // 呼叫非靜態方法
            Class_7_2.Punch();

            // 取得靜態資料(成員)
            // 類別名稱.靜態成員
            Debug.Log($"<color=#f3d>靜態成員 : {Class_7_2_Static.inventoryprop}</color>");
            // 取得靜態屬性
            Debug.Log($"<color=#f3d>靜態成員 : {Class_7_2_Static.skillSecond}</color>");
            // 呼叫靜態方法
            Class_7_2_Static.Kick();
        }

        public Class_7_2_slime slimeGreen, slimeBlue;

        private void Start()
        {
            // 非靜態成員
            slimeGreen.hp -= 10;
            Debug.Log($"<color=#3f3>綠色史萊姆 HP : {slimeGreen.hp}</color>");
            slimeBlue.hp -= 10;
            Debug.Log($"<color=#3f3>藍色史萊姆 HP : {slimeBlue.hp}</color>");


            Debug.Log($"<color=#3f3>史萊姆移動速度 : {Class_7_2_slime.moveSpeed}</color>");
        }
    }
}
