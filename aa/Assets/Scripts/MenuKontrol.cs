using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
    void Start()
    {
        //PlayerPrefs.DeleteAll();    
    }
    public void oyunaGit()
    {
        int kayıtLeveli = PlayerPrefs.GetInt("kayıt");
        if(kayıtLeveli == 0)
        {
            SceneManager.LoadScene(kayıtLeveli + 1);
        }
        else
        {
            SceneManager.LoadScene(kayıtLeveli);
        }
    }

    public void cık()
    {
        Application.Quit();
    }
}
