using UnityEngine;
using TMPro;

public class CongratsManager : MonoBehaviour
{
    public TMP_Text congratsText;
    private string PlayerName;

    void Awake()
    {
        PlayerName = PlayerPrefs.GetString("playerName", "Mr X");
        ShowCongratsMessage();
    }

    void ShowCongratsMessage()
    {
        congratsText.text = $"Congratulations, {PlayerName}!";
    }
}