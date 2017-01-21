using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

    Sprite[] AllImages;
    pelaaja player;
    Image UIImage;
    GameObject pauseMenu;

    public bool gamePaused = false;
    List<Sprite> StateImages = new List<Sprite>();

    void Start()
    {
        //Hakee kaikki spritet
        AllImages = Resources.LoadAll<Sprite>("Sprites/uipsritesheet01");

        //Valkkaa vain oikeat spritet uuteen listaan
        for(int k = 12; k < 16; k++)
            StateImages.Add(AllImages[k]);

        StateImages.Reverse();
        player = FindObjectOfType<pelaaja>();
        UIImage = GetComponentInChildren<Image>();
        pauseMenu = GameObject.Find("PauseMenu");
        pauseMenu.SetActive(false);

    }

    void Update()
    {
        UIImage.sprite = StateImages[player.hp]; //tohon sisälle tukee:  player.hp

        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!gamePaused) {
                pauseGame();
            } else {
                unPauseGame();
            }
        } 
    }

    void pauseGame()
    {
        gamePaused = true;
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    public void unPauseGame()
    {
        gamePaused = false;
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void LoadMenu()
    {
        Application.LoadLevel(0);
    }
}
