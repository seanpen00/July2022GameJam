using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueActive : MonoBehaviour
{
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        this.sr.sortingLayerName = "Default";
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MainCharacter")
        {
            this.sr.sortingLayerName = "Characters";
        }
        Debug.Log("BRUH");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MainCharacter")
        {
            this.sr.sortingLayerName = "Default";
        }
    }
}
