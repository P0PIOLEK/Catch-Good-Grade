using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance = null;

    public int currentLevel;

    public string[] LevelNames;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this) 
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpelLevel(int newlevelNum)
    {
        SceneManager.LoadScene(LevelNames[newlevelNum]);
    }

}
