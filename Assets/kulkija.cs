using UnityEngine;
using System.Collections;
public enum Sanat {finger,peukku,hevi,perus,suupdood,longlive };
public class kulkija : MonoBehaviour {

    public bool expecting = false;
    public Sanat whatToExpect;
    public bool done = false;
    public AudioClip[] soundsGood;
    public AudioClip[] soudsBad;
    public int model;
    public AudioSource ass;
    SpriteRenderer hello;
    SpriteRenderer fu;
    GameObject player;
	// Use this for initialization
	void Start () {
    ass = GameObject.Find("Audio").GetComponent<AudioSource>();
    hello = transform.Find("hello").GetComponent<SpriteRenderer>();
    hello.enabled = false;
    fu = transform.Find("fu").GetComponent<SpriteRenderer>();
    fu.enabled = false;
	//asd
    player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	if(expecting && whatToExpect != Sanat.finger && !done) {
    hello.enabled = true;
    }
    if(expecting && whatToExpect == Sanat.finger && !done) {
    fu.enabled = true;
    }
    
    
	}

    public void AudioGood() {
    if(!ass.isPlaying) {
    int tmp = Random.Range(0,soundsGood.Length);
    ass.clip = soundsGood[tmp];
    ass.Play();
    }
    }
     public void AudioBad() {
     if(!ass.isPlaying) {
    int tmp = Random.Range(0,soundsGood.Length);
    ass.clip = soudsBad[tmp];
    ass.Play();
    }
    }



    public int GetMessage(Sanat a) {
    if((whatToExpect == Sanat.finger && expecting) && !done) {
    if(a == Sanat.finger) {done = true;hello.enabled = false; fu.enabled = false; AudioGood(); return 1;}else { done = true; hello.enabled = false; fu.enabled = false; AudioBad();return -1;}
    }
    if((expecting && a != Sanat.finger) && !done) {
    done = true;
    hello.enabled = false;
    fu.enabled = false;
    AudioGood();
    return 1;
    }
    if(!done) {done = true;
    AudioBad();
    return -1; }

    return 0;

    }

    public void GiveExpect() {
            
    int tmp = Random.Range(0,6);
        switch (tmp)
        {
            case 0:
                whatToExpect = Sanat.finger;
                break;
            case 1:
                whatToExpect = Sanat.hevi;
                break;
            case 2:
                whatToExpect = Sanat.longlive;
                break;
            case 3:
                whatToExpect = Sanat.perus;
                break;
            case 4:
                whatToExpect = Sanat.peukku;
                break;
            case 5:
                whatToExpect = Sanat.suupdood;
                break;
            default:
                whatToExpect = Sanat.finger;
                break;
        }
        expecting = true;

    }
}
