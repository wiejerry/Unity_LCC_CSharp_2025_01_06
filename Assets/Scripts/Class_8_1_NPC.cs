using UnityEngine;

namespace Jerry
{
    /// <summary>
    /// NPC���O : NPC�W�ٻP��ܤ��e��ơA����X NPC �W�ٻP���ܪ��\��
    /// </summary>
    public class Class_8_1_NPC
    {
        private string name;
        private string dialogue;

        // �غc�l : �S���Ǧ^���O�A�W�ٻP�ۦP��������k
        // �w�]���c�l : �S���Ѽ�
        public Class_8_1_NPC()
        {
            Debug.Log("<color=#f3d>�w�]�غc�l</color>");
        }

        public Class_8_1_NPC(string _name)
        {
            name = _name;
            Debug.Log("<color=#f3d>���Ѽƪ��غc�l</color>");
        }

        public void LogName()
        {
            Debug.Log($"<color=#373>NPC ���W�� : {name}</color>");
        }

        public void Talk()
        {
            Debug.Log($"<color=#373>{dialogue}</color>");
        }
    }
}
