using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getArtifact : MonoBehaviour {
    public Sprite[] sprites;
    public string resourceName;
    int currentSprite = -1;
    // Use this for initialization
    void Start () {
        if (getSprite.clear == true)
        {
            sprites = Resources.LoadAll<Sprite>(resourceName);
            currentSprite = getSprite.currentSprite;
            if (currentSprite > sprites.Length)
                currentSprite = sprites.Length - 1;
            
            GetComponent<SpriteRenderer>().sprite = sprites[currentSprite];
        }
	}
	
	// Update is called once per frame
	void Update () {
        
    }

}
