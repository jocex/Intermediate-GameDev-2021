using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatChange : MonoBehaviour
{
    public Sprite NewSprite;
    public Sprite OldSprite;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)){
            gameObject.GetComponent<SpriteRenderer>().sprite = NewSprite;
        }

        if (Input.GetKeyDown(KeyCode.D)){
            gameObject.GetComponent<SpriteRenderer>().sprite = OldSprite;
        }
    }
}
