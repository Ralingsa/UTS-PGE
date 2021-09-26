using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneCtrl : MonoBehaviour
{
    public bool isEscToExit;

    public void startLevel1()
    {
        SceneManager.LoadScene("level1");
    }

    public void startLevel2()
    {
        SceneManager.LoadScene("level2");
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
        
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isEscToExit)
            {
                Application.Quit();
            }
            else
            {
                backToMenu();
            }
        }
    }
}
