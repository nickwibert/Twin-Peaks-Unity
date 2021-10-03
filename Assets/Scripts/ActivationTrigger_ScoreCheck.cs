using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationTrigger_ScoreCheck : MonoBehaviour {

    [SerializeField] private GameObject goodEnding;
    [SerializeField] private GameObject badEnding;
    public GameManager_SideScroller gameManager;

    void Start()
    {
        goodEnding.SetActive(false);
        badEnding.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && gameManager.score == 70)
        {
            goodEnding.SetActive(true);
        }
        else if (collision.CompareTag("Player"))
        {
            badEnding.SetActive(true);
        }
    }

    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.CompareTag("Player"))
    //    {
    //        displayed.SetActive(false);
    //    }
    //}
}
