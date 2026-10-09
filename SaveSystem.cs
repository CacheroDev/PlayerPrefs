

using UnityEngine;
using TMPro;

public class SaveSystem : MonoBehaviour
{
    [SerializedField] TMP_InputField _input;

    public void SaveData()
    {
        PlayerPrefs.SetString("Score", _input.text);
    }

    public void LoadData()
    {
        _input.text = PlayerPrefs.GetString("Score");
    }
    
    public void DeleteData()
    {
        PlayerPrefs.DeleteKey("Score");
    }
}
