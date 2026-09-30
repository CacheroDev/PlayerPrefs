

using UnityEngine;
using TMPro;

public class PlayerPreferences : MonoBehaviour
{
    int score;
    TextMeshProUGUI textScore;

    void SaveData()
    {
        PlayerPrefs.SetInt("score", score);
    }

    void LoadData()
    {
        textScore.text = "Score: " + PlayerPrefs.GetInt("score");
    }
}
