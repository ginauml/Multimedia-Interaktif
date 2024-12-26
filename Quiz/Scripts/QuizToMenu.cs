using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizToMenu : MonoBehaviour
{
    public void GoToMenu()
    {
        // Simpan informasi target panel ke PlayerPrefs
        PlayerPrefs.SetString("TargetPanel", "Menu");
        PlayerPrefs.Save();

        // Pindah ke SampleScene
        SceneManager.LoadScene("SampleScene");
    }
}
