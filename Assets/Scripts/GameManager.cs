using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_InputField inputName;
    public string playerName;
    public static GameManager Instance;

    private void Awake() {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }    

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void PlayerName(string name) {
        GameManager.Instance.playerName = name;
    }

    public void StartGame(){
        PlayerName(inputName.text);
        SceneManager.LoadScene(1);
    }

    public void ExitGame() {
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }

}
