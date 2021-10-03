using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public GameObject Object;
 
    public void PlayGame()
    {
        SceneManager.LoadScene("Dream");
    }
}
