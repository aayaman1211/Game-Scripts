using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject playerSpawn;
    public Transform spawnPos;
    public int noOfPlayers = 2;
    public int comparer = 1;
    public TextMesh noOfPlayersText;

    // Start is called before the first frame update
    void Start()
    {
        /*for(int i = 1; i <= noOfPlayers; i++)
        {
            GameObject spawner = Instantiate(playerSpawn, spawnPos.position + new Vector3(Random.Range(0.1f, 0.5f), 0f, Random.Range(0.1f, 0.5f)), Quaternion.identity);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if(noOfPlayers > comparer)
        {
            comparer++;
            GameObject spawner = Instantiate(playerSpawn, spawnPos.position + new Vector3(Random.Range(0.1f, 0.5f), 0f, Random.Range(0.1f, 0.5f)), Quaternion.identity);
        }

        noOfPlayersText.text = ("" + noOfPlayers);
    }
}
