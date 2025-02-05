using UnityEngine;

[CreateAssetMenu(fileName = "NewEpisode", menuName = "VN/Episode")]
public class VNEpisode : ScriptableObject
{
    public string episodeName; // �������� �������
    public VNScene[] scenes; // ������ ���� � �������
}
