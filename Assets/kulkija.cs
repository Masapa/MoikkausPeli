using UnityEngine;
using System.Collections;
public enum Sanat {finger,peukku,hevi,perus,suupdood,longlive };
public class kulkija : MonoBehaviour {

    public bool expecting = false;
    public Sanat whatToExpect;
	// Use this for initialization
	void Start () {
	//asd
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool GetMessage(Sanat a) {
    if(expecting && whatToExpect != Sanat.finger || (expecting && a == whatToExpect)) {
    return true;
    }
    return false;

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
