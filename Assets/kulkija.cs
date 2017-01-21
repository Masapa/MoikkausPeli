using UnityEngine;
using System.Collections;
public enum Sanat {finger,peukku,hevi,perus,suupdood,longlive };
public class kulkija : MonoBehaviour {

    public bool expecting = false;
    public Sanat whatToExpect;
    public bool done = false;
    SpriteRenderer hello;
    SpriteRenderer fu;
    GameObject player;
	// Use this for initialization
	void Start () {
    hello = transform.Find("hello").GetComponent<SpriteRenderer>();
    hello.enabled = false;
    fu = transform.Find("fu").GetComponent<SpriteRenderer>();
    fu.enabled = false;
	//asd
    player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	if(expecting && whatToExpect != Sanat.finger) {
    hello.enabled = true;
    }
    if(expecting && whatToExpect == Sanat.finger) {
    fu.enabled = true;
    }
    
    
	}

    public int GetMessage(Sanat a) {
    if((expecting && whatToExpect != Sanat.finger || (expecting && a == whatToExpect)) && !done) {
    done = true;
    return 1;
    }
    if(!done) {done = true;
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
