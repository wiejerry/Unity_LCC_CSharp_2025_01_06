using Jerry.Tools;
using UnityEngine;

namespace Jerry
{
    /// <summary>
    /// 抽象
    /// </summary>
    public class Class_11_Abstract : MonoBehaviour
    {
        private void Awake()
        {
            // 抽象類別 :
            // 1. 必須使用關鍵字 abtract
            // 2. 不能被實力化 (new)
            // 3. 如果有抽象方法成員
            // 4. 抽象成員必須被子類別實作 (override)
            var flyDragon = new FlyDragon();
            var threeHornDragon = new ThreeHornDtagon();

            // var monster = new Monster()      // 錯誤 : 無法實力化抽象類別

            flyDragon.Attack();
            threeHornDragon.Attack();

            // 向上轉型 Upcasting : 實力化後存放到父類別
            // 向上轉型可以使用多形
            Monster fly = new FlyDragon();
            fly.Track();

            FlyDragon fly2 = new FlyDragon();
            fly2.Track();
            fly2.Track(100);
            FlyDragon fly3 = new FlyDragon();
            fly3.Track();
            fly3.Track(150);
        }
    }

    // abstract 抽象類別
    public abstract class Monster
    {
        public float hp;
        public float moveSpeed;

        // 抽象方法不需要主體 (大括號{})
        public abstract void Attack();

        public void Track()
        {
            LogSystem.LogWithColor("追蹤", "#f93");
        }
    }

    public class FlyDragon : Monster
    {
        public override void Attack()
        {
            LogSystem.LogWithColor("飛龍攻擊", "#f77");
        }

        public void Track(int speed)
        {
            LogSystem.LogWithColor($"追蹤，速度 :{speed}", "#f93");
        }
    }

    public class ThreeHornDtagon : Monster 
    {
        public override void Attack()
        {
            LogSystem.LogWithColor("三角龍攻擊", "#7f7");
        }
    }
}
