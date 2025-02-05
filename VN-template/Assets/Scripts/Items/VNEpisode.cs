using UnityEngine;

[CreateAssetMenu(fileName = "NewEpisode", menuName = "VN/Episode")]
public class VNEpisode : ScriptableObject
{
    public string episodeName; // Название эпизода
    public VNScene[] scenes; // Список сцен в эпизоде
}
