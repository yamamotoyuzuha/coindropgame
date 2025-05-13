using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("コイン所持数")]
    public int currentCoin; //コイン所持数

    [Header("UI")]
    public TextMeshProUGUI coinText;

    public GameObject gameOverUIObj;

    public bool isGameOver; //ゲームオーバー判定

    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        currentCoin = 10; //初期所持数
        gameOverUIObj.SetActive(false);
        isGameOver = false;
    }

    void Update()
    {
        coinText.text = "Coin" + " " + ":" + " " + currentCoin; //所持数を増やす

        if(currentCoin <= 0) //コイン所持が０になったら
        {
            Debug.Log("GameOver");
            gameOverUIObj.SetActive(true);
            isGameOver = true;
        }
    }

    public void AddCoin() //コイン加算
    {
        currentCoin++;
    }

    public void SubtractionCoin() //コイン減算
    {
        currentCoin--;
    }

    public void ReStart() //リトライ
    {
        SceneManager.LoadScene("GameScene");
    }
}
