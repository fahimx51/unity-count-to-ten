using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WelcomeManager : MonoBehaviour
{
    public string playerName;
    public TMP_Text warningText;
    public TMP_InputField nameInputField;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (PlayerPrefs.HasKey("playerName"))
        {
            SceneManager.LoadScene("02_CounterScreen");
        }
    }

    public void ContinueClicked()
    {
        playerName = nameInputField.text.Trim();

        if (string.IsNullOrEmpty(playerName))
        {
            warningText.text = "Please enter a valid name.";
            return;
        }

        warningText.text = "";

        PlayerPrefs.SetString("playerName", playerName);
        SceneManager.LoadScene("02_CounterScreen");
    }
}
