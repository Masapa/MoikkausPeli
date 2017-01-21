using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapGen : MonoBehaviour {

    private string Map = "Neighbourhoods";
    GameObject[] Blocks;
    GameObject curBlock;

    void Start () {

        //Lataa palikat listaan riippuen minkä kentän haluaa
        Blocks = Resources.LoadAll<GameObject>("Prefabs/" + Map);
        curBlock = Blocks[Random.Range(0, Blocks.Length)];
        curBlock = Instantiate(curBlock, gameObject.transform.position, Quaternion.identity) as GameObject;

        SpawnBlock();
        SpawnBlock();
        SpawnBlock();
        SpawnBlock();
        SpawnBlock();
    }

    void SpawnBlock()
    {
        //Kahtoo ettei tuu kahta samanlaista palikkaa putkeen
        GameObject temp = Blocks[Random.Range(0, Blocks.Length)];
        while (temp == curBlock) {
            temp = Blocks[Random.Range(0, Blocks.Length)];
        }

        //Eka kahtoo mihinkä laitetaan ja sitte spawnaa uutena palikkana
        Vector3 pos = curBlock.transform.FindChild("Endpoint").position;
        curBlock = Instantiate(temp, pos, Quaternion.identity) as GameObject;
    }
}
