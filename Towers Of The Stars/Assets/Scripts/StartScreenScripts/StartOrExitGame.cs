using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartOrExitGame : MonoBehaviour
{
    public string buttonName;

    public void OnClick()
    {
        //buttonName = gameObject.name;

        switch (buttonName.ToLower())
        {
            case "play":
                SceneManager.LoadScene(1);
                return;
            case "exit":
                Application.Quit();
                return;
        }
    }
}
