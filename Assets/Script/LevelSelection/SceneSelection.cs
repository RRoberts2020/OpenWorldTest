using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSelection : MonoBehaviour {

    public void MainScene(string MainScene)
    {
        SceneManager.LoadScene(MainScene);
    }
    public void Perlin_NoiseMapScene(string Perlin_Noise)
    {
        SceneManager.LoadScene(Perlin_Noise);
    }
    public void WFC_MapScene(string WFC_Map)
    {
        SceneManager.LoadScene(WFC_Map);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }
}
