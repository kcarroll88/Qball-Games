using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject quitButton;
    [SerializeField] GameObject qballMainMenuText;
    [SerializeField] GameObject hotPotatoeButton;

    // Start is called before the first frame update
    void Start()
    {
        EnableMainMenuButtons();
        hotPotatoeButton.SetActive(false);
    }

    public void EnableMainMenuButtons()
    {
        startButton.SetActive(true);
        quitButton.SetActive(true);
        qballMainMenuText.SetActive(true);
    }

    public void DisableMainMenuButtons()
    {
        startButton.SetActive(false);
        quitButton.SetActive(false);
        qballMainMenuText.SetActive(false);
    }

    public void EnableGameButtons()
    {
        StartCoroutine(GameMenuCoroutine());
    }

    IEnumerator GameMenuCoroutine()
    {
        yield return new WaitForSeconds(1f);
        hotPotatoeButton.SetActive(true);
    }
}
