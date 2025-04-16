using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worldblockspawner : MonoBehaviour
{
    [SerializeField]
    GameObject [] blocks;
    public Transform spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBlock() 
    {
        int randomIndex = Random.Range(0, blocks.Length);
        GameObject block = Instantiate(blocks [randomIndex], transform.position, Quaternion.identity);
        block.transform.SetParent(transform);
    }

}
