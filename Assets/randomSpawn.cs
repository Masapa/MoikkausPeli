using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class randomSpawn : MonoBehaviour {
    List<GameObject> lista;
    GameObject[] ukot;
    List<GameObject> listaa;
	// Use this for initialization
	void Start () {
    lista = new List<GameObject>();
    listaa = new List<GameObject>();


     foreach(Transform t in transform)
 {
 Debug.Log(t.name);
    if(t.name.Contains("Spawn")) {
    Debug.Log("asdd");
    lista.Add(t.gameObject);
    }

    }
        ukot = Resources.LoadAll<GameObject>("Prefabs/Ukkelit");
    foreach(GameObject a in lista) {
    Debug.Log("UKKO TEHTY");
        listaa.Add(Instantiate(ukot[Random.Range(0,ukot.Length)],a.transform,false) as GameObject);
       
    } 

    for(int i = 0;i<4;i++) {
    int tmp = Random.Range(0,listaa.Count);
    listaa[tmp].GetComponent<kulkija>().GiveExpect();
    
    }


 }


	
	
	
	// Update is called once per frame
	void Update () {
	
	}
}

