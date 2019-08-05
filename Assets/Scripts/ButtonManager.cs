using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject startButton;
    [SerializeField] GameObject quitButton;
    [SerializeField] GameObject qballMainMenuText;

    // Start is called before the first frame update
    void Start()
    {
        EnableButtons();
    }

    private void Update()
    {
        
    }

    public void EnableButtons()
    {
        startButton.SetActive(true);
        quitButton.SetActive(true);
        qballMainMenuText.SetActive(true);
    }

    public void DisableButtons()
    {
        startButton.SetActive(false);
        quitButton.SetActive(false);
        qballMainMenuText.SetActive(false);
    }
}
