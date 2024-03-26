using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainMenu : MonoBehaviour
{
    public GameObject mainMenuObj;
    public GameObject gameOverMenu;

    // Start is called before the first frame update
    void Start() {
        mainMenuObj.SetActive(true);
        gameOverMenu.SetActive(false);
        Game.Instance.input.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() {
        mainMenuObj.SetActive(false);
        gameOverMenu.SetActive(false);
        Game.Instance.input.Enable();
    }

    public void GameOver() {
        mainMenuObj.SetActive(false);
        gameOverMenu.SetActive(true);
        Game.Instance.input.Disable();
    }
}
