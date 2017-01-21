using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapGen : MonoBehaviour {

    private string Map = "Neighbourhoods";
    List<GameObject> SpawnedBlocks = new List<GameObject>();
    public GameObject Player;
    GameObject[] Blocks;
    GameObject curBlock;

    void Start () {

        //Lataa palikat listaan riippuen minkä kentän haluaa ja spawnaa ensimmäisen palikan
        Blocks = Resources.LoadAll<GameObject>("Prefabs/" + Map);
        curBlock = Blocks[Random.Range(0, Blocks.Length)];
        curBlock = Instantiate(curBlock, gameObject.transform.position, Quaternion.identity) as GameObject;
        SpawnedBlocks.Add(curBlock);

        while (SpawnedBlocks.Count < 16) {
            SpawnBlock();
        }
    }

    void Update()
    {
        if (Player.transform.position.x > SpawnedBlocks[2].transform.position.x) {
            Destroy(SpawnedBlocks[0]);
            SpawnedBlocks.RemoveAt(0);
            SpawnBlock();
        }
    }

    void SpawnBlock()
    {
        //Kahtoo ettei tuu kahta samanlaista palikkaa putkeen
        GameObject temp = Blocks[Random.Range(0, Blocks.Length)];
        while (temp.name + "(Clone)" == curBlock.name) {
            temp = Blocks[Random.Range(0, Blocks.Length)];
        }

        //Eka kahtoo mihinkä laitetaan ja sitte spawnaa uutena palikkana
        Vector3 pos = curBlock.transform.FindChild("Endpoint").position;
        curBlock = Instantiate(temp, pos, Quaternion.identity) as GameObject;
        SpawnedBlocks.Add(curBlock);
    }
}
