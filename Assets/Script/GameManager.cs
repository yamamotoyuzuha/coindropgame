using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("�R�C��������")]
    public int currentCoin; //�R�C��������

    [Header("UI")]
    public TextMeshProUGUI coinText;

    public GameObject gameOverUIObj;

    public bool isGameOver; //�Q�[���I�[�o�[����

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

        currentCoin = 10; //����������
        gameOverUIObj.SetActive(false);
        isGameOver = false;
    }

    void Update()
    {
        coinText.text = "Coin" + " " + ":" + " " + currentCoin; //�������𑝂₷

        if(currentCoin <= 0) //�R�C���������O�ɂȂ�����
        {
            Debug.Log("GameOver");
            gameOverUIObj.SetActive(true);
            isGameOver = true;
        }
    }

    public void AddCoin() //�R�C�����Z
    {
        currentCoin++;
    }

    public void SubtractionCoin() //�R�C�����Z
    {
        currentCoin--;
    }

    public void ReStart() //���g���C
    {
        SceneManager.LoadScene("GameScene");
    }
}
