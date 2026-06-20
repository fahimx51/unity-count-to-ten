using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class CounterManager : MonoBehaviour
{

    public int counter = 0;
    public TMP_Text counterText;

    void Start()
    {
        counter = PlayerPrefs.GetInt("CounterValue", 0);
        DisplayCounter();
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
            counter = 0;
            SaveCounter();
            SceneManager.LoadScene("03_CongratsScreen");
        }
    }
}
