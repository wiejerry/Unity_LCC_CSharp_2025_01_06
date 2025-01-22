using UnityEngine;

namespace Jerry
{
    /// <summary>
    /// 陣列 Array
    /// </summary>
    public class Class_6_2_Array : MonoBehaviour
    {
        // 不使用陣列的寫法 :
        // 皮卡丘、小火龍、卡比獸
        public string card1 = "皮卡丘", card2 = "小火龍", card3 = "卡比獸";

        // 使用陣列的寫法 :
        // 陣列 : 用來儲存多筆相同類型的資料
        // 第一種 不指定值，透過 Unity 面板輸入
        // 修飾詞 資料類型[] 陣列名稱
        public string[] cards;
        // 第二種 :直接定義陣列的數量
        // 定義一個牌組1，可以放五張卡牌
        public string[] deck1 = new string[5];
        //第二種 :直接定義陣列的值
        public string[] deck2 = { "急凍鳥", "大舌頭", "傑尼龜" };

        // 二維陣列
        public string[,] invenyory = { { "紅色藥水", "藍色藥水" }, { "炸彈", "金幣" } };
        // 三維陣列
        public string[,,] shop =
        {
            // 第一頁
            { {"水果刀","開山刀" } , {"太刀","倚天劍"} },
            // 第二頁
            { {"精靈球","高級球"}, {"大師球","巢穴球"} }
        };

        private void Start()
        {
            #region 一維陣列
            // 存取陣列 Sat、Get
            // Get 取得陣列資料
            // 陣列名稱[編碼]
            Debug.Log($"<color=#f32>Cards 的第三張卡片 : {cards[2]}</color>");
            // 超出陣列範圍，會導致錯誤
            // 錯誤會導致當機、閃退、不符合預期的結果或者不執行下方程式
            //Debug.Log($"<color=#f32>Cards 的第四張卡片 : {card[3]}</color>");

            // Sat 設定陣列的資料
            // 陣列名稱[編號] 指定 值;
            // 將傑尼龜換成傑水箭龜
            deck2[2] = "水箭龜";            
            Debug.Log($"<color=#f39>Deck2 的第三張卡片 : {deck2[2]}</color>");
            #endregion

            #region 二維與三維陣列
            // 存取二維陣列
            Debug.Log($"<color=#3f3>編號[0, 1]的道具 : {invenyory[0, 1]}</color>");

            invenyory[1, 1] = "好傷藥";
            Debug.Log($"<color=#3f3>編號[1,1]的道具 : {invenyory[1, 1]}</color>");

            // 存取三維陣列
            // 取得倚天劍
            Debug.Log($"<color=#f3d>第一頁第二排第二個 : {shop[0, 1, 1]}</color>");

            // 設定高級球為超級球
            shop[1, 0, 1] = "超級球";
            Debug.Log($"<color=#f3d>第二頁第一排第二個 : {shop[1, 0, 1]}</color>");
            #endregion

            // 獲得陣列長度或維度
            // 一維 ~ 多維陣列的長度 : 陣列名稱.Length
            Debug.Log($"<color=#f93>一維 - 排組 2 的長度 : {deck2.Length}</color>");
            Debug.Log($"<color=#f93>二維 - 道具的長度 : {invenyory.Length}</color>");
            Debug.Log($"<color=#f93>三維 - 商品的長度 : {shop.Length}</color>");
            // 陣列的維度 : 陣列名稱.Rank
            Debug.Log($"<color=#f93>一維 - 排組 2 的維度 : {deck2.Rank}</color>");
            Debug.Log($"<color=#f93>二維 - 道具的維度 : {invenyory.Rank}</color>");
            Debug.Log($"<color=#f93>三維 - 商品的維度 : {shop.Rank}</color>");
        }
    }
}
