using UnityEngine;

namespace Jerry
{
    /// <summary>
    /// �}�C Array
    /// </summary>
    public class Class_6_2_Array : MonoBehaviour
    {
        // ���ϥΰ}�C���g�k :
        // �֥d�C�B�p���s�B�d���~
        public string card1 = "�֥d�C", card2 = "�p���s", card3 = "�d���~";

        //
        // �}�C : �Ψ��x�s�h���ۦP���������
        // �Ĥ@�� �����w�ȡA�z�L Unity ���O��J
        // �׹��� �������[] �}�C�W��
        public string[] cards;
        // �ĤG�� :�����w�q�}�C���ƶq
        // �w�q�@�ӵP��1�A�i�H�񤭱i�d�P
        public string[] deck1 = new string[5];
        //�ĤG�� :�����w�q�}�C����
        public string[] deck2 = { "��᳾", "�j���Y", "�ǥ��t" };

        // �G���}�C
        public string[,] invenyory = { { "�����Ĥ�", "�Ŧ��Ĥ�" }, { "���u", "����" } };

        private void Start()
        {
            #region �@���}�C
            // �s���}�C Sat�BGet
            // Get ���o�}�C���
            // �}�C�W��[�s�X]
            Debug.Log($"<color=#f32>Cards ���ĤT�i�d�� : {cards[2]}</color>");
            // �W�X�}�C�d��A�|�ɭP���~
            // ���~�|�ɭP����B�{�h�B���ŦX�w�������G�Ϊ̤�����U��{��
            //Debug.Log($"<color=#f32>Cards ���ĥ|�i�d�� : {card[3]}</color>");

            // Sat �]�w�}�C�����
            // �}�C�W��[�s��] ���w ��;
            // �N�ǥ��t�����Ǥ��b�t
            deck2[2] = "���b�t";            
            Debug.Log($"<color=#f39>Deck2 ���ĤT�i�d�� : {deck2[2]}</color>");
            #endregion

            // �s���G���}�C
            Debug.Log($"<color=#3f3>�s��[0, 1]���D�� : {invenyory[0, 1]}</color>");

            invenyory[1, 1] = "�n����";
            Debug.Log($"<color=#3f3>�s��[1,1]���D�� : {invenyory[1,1]}</color>");
        }
    }
}
