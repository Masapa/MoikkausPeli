using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {
    public AudioClip overi;
    Sprite[] AllImages;
    pelaaja player;
    Image UIImage;
    GameObject pauseMenu;
    Text pisteet;
    GameObject over;

    public bool gamePaused = false;
    List<Sprite> StateImages = new List<Sprite>();

    void Start()
    {
    over = GameObject.Find("gameOver");

    over.SetActive(false);
    pisteet = transform.FindChild("Pisteet").GetComponent<Text>();
        //Hakee kaikki spritet
        AllImages = Resources.LoadAll<Sprite>("Sprites/uipsritesheet01");

        //Valkkaa vain oikeat spritet uuteen listaan
        for(int k = 17; k < 21; k++)
            StateImages.Add(AllImages[k]);

        StateImages.Reverse();
        player = FindObjectOfType<pelaaja>();
        UIImage = GetComponentInChildren<Image>();
        pauseMenu = GameObject.Find("PauseMenu");
        pauseMenu.SetActive(false);

    }

    void Update()
    {
    if(player.hp>=0) {
        UIImage.sprite = StateImages[player.hp]; //tohon sisälle tukee:  player.hp
        }
        if(player.hp<=0) {
        GameObject.Find("faili").GetComponent<AudioSource>().clip = overi;
        
        GameObject.Find("faili").GetComponent<AudioSource>().Play();
       // Time.timeScale = 0.0001f;
        gamePaused = true;
        over.SetActive(true);
        if(Input.GetKey(KeyCode.Escape)) {Application.LoadLevel(0); }

       


        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!gamePaused) {
                pauseGame();
            } else {
                unPauseGame();
            }
        } 

        pisteet.text = "Pisteet: "+player.points;

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
