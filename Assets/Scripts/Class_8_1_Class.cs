using UnityEngine;

namespace Jerry
{ 
    /// <summary>
    /// ���O Class
    /// </summary>
    public class Class_8_1_Class : MonoBehaviour
    {
        // ���O :
        // �Ψөw�q�@�Ӫ���H�ΥL�Ҿ֦�����ƻP�\�� (����)

        private void Awake()
        {
            // ��O�� NPC ���x�s�b npcJack �ܼƤ�
            Class_8_1_NPC npcJack = new Class_8_1_NPC();
            Class_8_1_NPC npcJerry = new Class_8_1_NPC("Jerry");

            npcJack.LogName();
            npcJerry.LogName();
        }
    }
}
