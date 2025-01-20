using Unity.VisualScripting;
using UnityEngine;

// 命名空間 :
// 將類別分類，類似倉庫的概念。不同倉庫可以有相同名稱類別。
// 語法 : namespace 命名空間名稱{ 內容 }
namespace Jerry
{
    /// <summary>
    /// 選取陳述式 Selection Statement
    ///  1. if 判斷式
    ///  2. Switch 判斷式
    /// </summary>

    public class Class_5_1_Selection : MonoBehaviour
    {
        [SerializeField, Header("是否開門")]
        private bool isOpen;
        [SerializeField, Header("分數"), Range(0, 100)]
        private int score = 100;
        [SerializeField, Header("武器")]
        private string weapon;
        [SerializeField, Header("血量"), Range(0, 100)]
        private int hp = 100;

        private void Awake()
        {
            // if 判斷式
            // if (布林值) {陳述式}
            if (true)
            {

                Debug.Log("當布林值為 True，會執行這裡");
            }

            // 快速完成 : 輸入 if 選取 if 陳述式按 Enter 或 Tab
            if (false)
            {
                Debug.Log("當布林值為 False，不會執行這裡而且會有綠蚯蚓");
            }
        }

        // 更新事件 : 一秒鐘執行約 60 次 (60FPS) Frame Per Second
        private void Update()
        {
            // 常用快捷鍵
            // 1. 格式化 (排版) Ctrl + K D
            // 2. 程式碼片段 Crrl + K S 選 region
            #region 判斷式 if
            Debug.Log("<color=#f93>更新事件</color>");

            // 如果 isOpen 布林值等於 True，就顯示開門
            if (isOpen)
            {
                Debug.Log("<color=#f93>已經開門</color>");

            }
            // 否則 isOpen 布林值等於 False，顯示開門
            else
            {
                Debug.Log("<color=#f93>門關了</color>"); 
            }
            // 比較運算值、邏輯運算子結果為布林值
            // if 會在最上方、else 在最下方，中間可以多個 else if
            // 如果分數 >= 60 就通過
            if (score >= 60)
            {
                Debug.Log("<color=#3f3>恭喜你 C# 課程過了</color>");
            }
            // 否則 如果 分數 >= 40 可以補考
            else if (score >= 40)
            {
                Debug.Log("<color=#f96>你可以補考 C#</color>");
            }
            // 否則 如果 分數 >= 20 可以補考並做一個小專題
            else if (score >= 20)
            {              
                Debug.Log("<color=#f9a>可以補考但一定要做一個 C# 小專題</color>");
            }
            // 否則 當掉
            else
            {
                Debug.Log("<color=#f33>你的 C# 課程被當了</color>");
            }
            #endregion

            #region 判斷式 switch
            // switch 判斷式
            // switch (要判斷的值) { 陳述式 }
            // 快速完成 : switch + Tab * 2           
            switch (weapon)
            {
                // case 值:
                // 當判斷式的值等於值時會執行這裡
                // break; 跳出判斷式
                // 如果武器等於小刀，攻擊力等於 20              
                case "開山刀":
                    Debug.Log("<color=#ff3>攻擊力: 20</color>");
                    break;
                // 蝴蝶刀會與小刀一樣
                case "蝴蝶刀":
                case "小刀":
                    Debug.Log("<color=#ff3>攻擊力: 10</color>");
                    break;
                case "倚天劍":
                    Debug.Log("<color=#ff3>攻擊力: 999</color>");
                    break;

                // 當 weapon 的值不等於上面的所有值會執行這裡
                default:
                    Debug.Log("<color=#ff3>這是不能使用的武器</color>");
                    break ;

            }
            #endregion

            #region 練習
            if (hp >= 80)
            {
                Debug.Log("<color=#f93>安全無狀況</color>");
            }
            else if(hp >= 60)
            {
                Debug.Log("<color=#f93>受到攻擊</color>");
            }
            else if(hp >= 40)
            {
                Debug.Log("<color=#f93>再不喝藥水要死了</color>");
            }
            else if (hp >= 10)
            {
                Debug.Log("<color=#f93>快死了</color>");
            }
            else if (hp >= 0)
            {
                Debug.Log("<color=#f93>你死了</color>");
            }
            #endregion
        }
    }
}
