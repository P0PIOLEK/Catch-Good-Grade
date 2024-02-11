using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverControl : MonoBehaviour
{
    private GameObject succesPanel;
    private GameObject failPanel;
    private GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        gameOverCanvas = GameObject.Find("GameOverCanvas");
        if ( gameOverCanvas != null)
        {
            failPanel = gameOverCanvas.transform.GetChild(0).gameObject;
            succesPanel = gameOverCanvas.transform.GetChild(1).gameObject;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "End")
        {
            Debug.Log("Sukces");
            succesPanel.SetActive(true);
        }
        else if (other.gameObject.tag == "Borrder")
        {
            Debug.Log("Przegrana");
            failPanel.SetActive(true);
        }
    }
}
