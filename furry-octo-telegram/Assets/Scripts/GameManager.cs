using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float gameSpeed;
    public float gameSpeedMultiplier;
    public int score;

    #region Singleton
    public static GameManager _instance;
    private void Awake()
    {
        if (GameManager._instance == null)
        {
            _instance = this;
            //DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    #endregion



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
