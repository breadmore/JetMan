using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class houseManager : MonoBehaviour {
    public GameObject get_artifact;
    public static int[] artifact_num=new int[5];
    string resource_name;
    bool gameclear = false;
    // Use this for initialization
    void Start () {
        if (getSprite.clear == true)
        {
            for (int i = 0; i < 5; i++)
            {
                if (artifact_num[i] == 1)
                {
                    Debug.Log("hey");
                    GameObject.Find("artifact").transform.Find(i.ToString()).gameObject.SetActive(true);
                }
            }

            artifact_num[getSprite.currentSprite] = 1;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.B) == true)
        {
            gameclear = true;
        }
        if (gameclear == true)
        {
            SceneManager.LoadScene("Splash");
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Player")
        {
            
            if (getSprite.clear == true)
            {
                for (int i=0; i<5; i++)
                {
                    if (artifact_num[i] == 1)
                    {
                        GameObject.Find("artifact").transform.Find(i.ToString()).gameObject.SetActive(true);
                    }
                    
                }
                get_artifact.SetActive(false);
                getSprite.clear = false;
            }

            for (int i = 0; i < 5; i++)
            {
                if (houseManager.artifact_num[i] == 0)
                {
                    gameclear = false;
                    break;
                }
                else
                {
                    gameclear = true;
                }
            }

        }
    }
}
