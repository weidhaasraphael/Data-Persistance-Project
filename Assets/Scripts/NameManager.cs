using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NameManager : MonoBehaviour
{
    //testing stuff from google because this challenge is very hard
    public static NameManager Instance;
    public string playerName;
    [SerializeField] private InputField nameInput;
    public Text Highscore;

    private void Start()
    {
    }
    private void Awake()
    {
        //destroy when trying to instantiate repeatedly
        if(Instance!=null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ProceedToMain()
    {
        playerName = nameInput.text;
        SceneManager.LoadScene(1);
    }

}
