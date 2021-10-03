using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelAfterSound : MonoBehaviour
{
    public float delay = 440;
    public string NewLevel = "Level1";
    void Start()
    {
        StartCoroutine(LoadLevelAfterDelay(delay));
    }

    IEnumerator LoadLevelAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(NewLevel);
    }
}