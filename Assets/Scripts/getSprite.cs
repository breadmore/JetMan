using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getSprite : MonoBehaviour {

    public Sprite[] sprites;
    public string resourceName;
    public static int currentSprite = -1;
    public static bool clear = false;
    RandomSprite rans;
    // Use this for initialization
    void Start () {
        rans = GameObject.Find("Artifact").GetComponent<RandomSprite>();
    }
	
	// Update is called once per frame
	void Update () {
        
        if (rans.check == true)
            if (resourceName != "")
            {
                sprites = Resources.LoadAll<Sprite>(resourceName);

                currentSprite = rans.currentSprite;
                if (currentSprite > sprites.Length)
                    currentSprite = sprites.Length - 1;
                
                GetComponent<SpriteRenderer>().sprite = sprites[currentSprite];
                rans.check = false;
                clear = true;
            }
    }
}
