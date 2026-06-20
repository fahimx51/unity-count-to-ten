using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CounterManager : MonoBehaviour
{

    private int counter;
    public TMP_Text counterText;

    void Awake()
    {
        counter = PlayerPrefs.GetInt("CounterValue", 0);
        DisplayCounter();
        CheckForCompletion();
    }

    public void IncrementCounter()
    {
        counter++;
        DisplayCounter();
        SaveCounter();
        CheckForCompletion();
    }

    public void DecrementCounter()
    {
        if (counter > 0)
        {
            counter--;
            DisplayCounter();
            SaveCounter();
        }
    }

    void DisplayCounter()
    {
        counterText.text = counter.ToString();
    }

    void SaveCounter()
    {
        PlayerPrefs.SetInt("CounterValue", counter);
        PlayerPrefs.Save();
    }

    void CheckForCompletion()
    {
        if (counter == 10)
        {
            SceneManager.LoadScene("03_CongratsScreen");
        }
    }
}
