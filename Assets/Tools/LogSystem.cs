using UnityEngine;

namespace Jerry.Tools
{
    /// <summary>
    ///  輸出訊息
    /// <summary>
    public class LogSystem
    {
        /// <summary>
        /// 輸出訊息並指定顏色
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        /// <returns>包含顏色的訊息</returns>
        public static string LogWithColor(string message, string color)
        {
            string result = $"<color={color}>{message}</color>";
            Debug.Log(result) ;
            return result ;
        }

    }
}
