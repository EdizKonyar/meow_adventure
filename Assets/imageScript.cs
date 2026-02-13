using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScript : MonoBehaviour
{
    // Cache the SpriteRenderer to avoid repeated GetComponent calls
    private SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        // Get the SpriteRenderer component and disable it at the start
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Toggle the SpriteRenderer's enabled state each time E key is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            spriteRenderer.enabled = !spriteRenderer.enabled;
        }
    }
}
