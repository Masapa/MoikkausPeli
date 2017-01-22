using UnityEngine;
using System.Collections;

public class pelaaja : MonoBehaviour {
    public float distance;
    Transform cam;
    hand asd;
        public AudioClip[] soundsGood;
    public AudioClip[] soudsBad;
    AudioSource ass;
    public int hp = 3;
    public int points = 0;
	// Use this for initialization
	void Start () {
        ass = GameObject.Find("pelaajasound").GetComponent<AudioSource>();
    asd = gameObject.GetComponentInChildren<hand>();
	cam  = Camera.main.transform;
    InvokeRepeating("AudioBad",2f,6f);
	}
	RaycastHit hit;
	// Update is called once per frame
	void Update () {
	if(Physics.Raycast(cam.position,cam.forward,out hit,distance) && hit.transform.tag == "kulkija" && asd.saako) {
    Debug.Log(hit.transform.name);
    int tmp = hit.collider.transform.GetComponent<kulkija>().GetMessage(asd.current);
    if(tmp == 1) {
    StartCoroutine(PlayAfterSecondG(0.5f));
    points++;
    }else if(tmp == -1) {hp--;StartCoroutine(PlayAfterSecondG(0.5f)); }
	}
    }


        IEnumerator PlayAfterSecondG(float time) {
    yield return new WaitForSeconds(time);
   AudioGood();
    }

        IEnumerator PlayAfterSecondV(float time) {
    yield return new WaitForSeconds(time);
    AudioBad();
    }

       public void AudioGood() {
    int tmp = Random.Range(0,soundsGood.Length);
    if(!ass.isPlaying) {
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

}
