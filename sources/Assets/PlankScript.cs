using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class PlankScript : MonoBehaviour
{
    public int levelIndex;
    private bool nearPlank;
    public bool titleScreen;
    public bool endScreen;
    
    // Update is called once per frame
    void Update()
    {
        if (nearPlank && Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(levelIndex); 
        }

        if (titleScreen && Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(14); 
        }

        if (endScreen && Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(0); 
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            nearPlank = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            nearPlank = false;
        }
    }
}
