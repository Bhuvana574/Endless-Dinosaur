using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToNextScene()
    {
        SceneManager.LoadScene(1);
    }
}
