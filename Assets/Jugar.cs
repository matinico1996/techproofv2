using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jugar : MonoBehaviour
{
   public void loadScene (string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }
}
