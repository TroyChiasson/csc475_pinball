using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenu : MonoBehaviour
{
    public GameObject mainMenuObj;
    public GameObject gameOverMenu;

    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public GameObject life4;

    // Start is called before the first frame update
    void Start() {
        mainMenuObj.SetActive(true);
        gameOverMenu.SetActive(false);
        GameManager.Instance.input.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() {
        
        mainMenuObj.SetActive(false);
        gameOverMenu.SetActive(false);
        GameManager.Instance.input.Enable();
    }

    public void GameOver() {
        mainMenuObj.SetActive(false);
        gameOverMenu.SetActive(true);
        GameManager.Instance.input.Disable();
    }

    public void ResetLives() {
        life1.SetActive(true);
        life2.SetActive(true);
        life3.SetActive(true);
        life4.SetActive(true);
    }
}
