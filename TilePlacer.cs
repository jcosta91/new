using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilePlacer : MonoBehaviour
{
    public GameObject wheatTile;
    public GameObject sheepTile;
    public GameObject oreTile;
    public GameObject woodTile;
    public GameObject clayTile;
    public GameObject desertTile;
    private GameObject spawnTile = null;

    private GameObject tileManager;

    // Start is called before the first frame update
    void Start()
    {
        GameObject manager = GameObject.Find("Manager");
        ManagerController tileManagerScript = manager.GetComponent<ManagerController>();

        int i = 0;
        int counter = 0;


        while (spawnTile == null)
        {
            i = Random.Range(1, 6);
            if (i == 1 && tileManagerScript.wheatCounter < 4)
            {
                spawnTile = wheatTile;
                tileManagerScript.wheatCounter++;
                //tileManagerScript.tiles.Add("wheat " + tileManagerScript.wheatCounter);
            }
            if (i == 2 && tileManagerScript.sheepCounter < 4)
            {
                spawnTile = sheepTile;
                tileManagerScript.sheepCounter++;
                //tileManagerScript.tiles.Add("sheep " + tileManagerScript.sheepCounter);
            }
            if (i == 3 && tileManagerScript.oreCounter < 3)
            {
                spawnTile = oreTile;
                tileManagerScript.oreCounter++;
                //tileManagerScript.tiles.Add("ore " + tileManagerScript.oreCounter);
                Debug.Log("current Ore Count: " + tileManagerScript.oreCounter);
            }
            if (i == 4 && tileManagerScript.woodCounter < 4)
            {
                spawnTile = woodTile;
                tileManagerScript.woodCounter++;
                //tileManagerScript.tiles.Add("wood " + tileManagerScript.woodCounter);
            }
            if (i == 5 && tileManagerScript.clayCounter < 3)
            {
                spawnTile = clayTile;
                tileManagerScript.clayCounter++;
                //tileManagerScript.tiles.Add("clay " + tileManagerScript.clayCounter);
            }
            //if (i == 6 && tileManagerScript.desertCounter < 1)
            //{
            //    spawnTile = desertTile;
            //    tileManagerScript.desertCounter++;
            //    Debug.Log("Desert tile assigned");
            //}

            if (counter >= 50)
            {
                Debug.Log("There was a problem selecting a tile.");
                break;
            }
            else
            {
                counter++;
            }

        }

        Instantiate(spawnTile, transform.position, transform.rotation);
        Destroy(gameObject);

    }
}
