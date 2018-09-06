using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlManager : MonoBehaviour {

	public void LoadLvl(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void QuitRequest()
    {
        Debug.Log("quit pressed");
        Application.Quit();
        
    }
}
