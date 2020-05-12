using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TokenPlacer : MonoBehaviour
{
    public GameObject tokenTwo;
    public GameObject tokenThree;
    public GameObject tokenFour;
    public GameObject tokenFive;
    public GameObject tokenSix;
    public GameObject tokenEight;
    public GameObject tokenNine;
    public GameObject tokenTen;
    public GameObject tokenEleven;
    public GameObject tokenTwelve;

    private GameObject tileManager;
    private GameObject tokenManager;
    private GameObject spawnToken = null;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        if (Time.time > startTime)
        {
            generateToken();
        }
    }

    void generateToken()
    {
        GameObject manager = GameObject.Find("Manager");
        ManagerController tokenManagerScript = manager.GetComponent<ManagerController>();

        int i = 0;
        int counter = 0;

        while (spawnToken == null)
        {
            i = Random.Range(2, 13);
            if (i == 2 && tokenManagerScript.two < 1)
            {
                spawnToken = tokenTwo;
                tokenManagerScript.two++;
            }
            if (i == 3 && tokenManagerScript.three < 2)
            {
                spawnToken = tokenThree;
                tokenManagerScript.three++;
            }
            if (i == 4 && tokenManagerScript.four < 2)
            {
                spawnToken = tokenFour;
                tokenManagerScript.four++;
            }
            if (i == 5 && tokenManagerScript.five < 2)
            {
                spawnToken = tokenFive;
                tokenManagerScript.five++;
            }
            if (i == 6 && tokenManagerScript.six < 2)
            {
                spawnToken = tokenSix;
                tokenManagerScript.six++;
            }
            if (i == 8 && tokenManagerScript.eight < 2)
            {
                spawnToken = tokenEight;
                tokenManagerScript.eight++;
            }
            if (i == 9 && tokenManagerScript.nine < 2)
            {
                spawnToken = tokenNine;
                tokenManagerScript.nine++;
            }
            if (i == 10 && tokenManagerScript.ten < 2)
            {
                spawnToken = tokenTen;
                tokenManagerScript.ten++;
            }
            if (i == 11 && tokenManagerScript.eleven < 2)
            {
                spawnToken = tokenEleven;
                tokenManagerScript.eleven++;
            }
            if (i == 12 && tokenManagerScript.twelve < 1)
            {
                spawnToken = tokenTwelve;
                tokenManagerScript.twelve++;
            }
            if (counter >= 50)
            {
                Debug.Log("There was a problem placing a token.");
                break;
            }
            else
            {
                counter++;
            }


        }
        Instantiate(spawnToken, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
