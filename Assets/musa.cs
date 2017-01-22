using UnityEngine;
using System.Collections;

public class musa : MonoBehaviour {
   public AudioClip asd;
    AudioSource ass;
	// Use this for initialization
	void Start () {
	ass = gameObject.GetComponent<AudioSource>();
    ass.clip = asd;
    StartCoroutine(PlayAfterSecond(3f));
	}
    IEnumerator PlayAfterSecond(float time) {
    yield return new WaitForSeconds(time);
    ass.Play();
    Debug.Log("Playing");
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
