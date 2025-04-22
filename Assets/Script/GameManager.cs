using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("�R�C��������")]
    public int currentCoin; //�R�C��������

    [Header("UI")]
    public TextMeshProUGUI coinText;

    public GameObject gameOverUIObj;

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
    }

    void Update()
    {
        coinText.text = "Coin" + " " + ":" + " " + currentCoin; //�������𑝂₷

        if(currentCoin <= 0) //�R�C���������O�ɂȂ�����
        {
            Debug.Log("GameOver");
            gameOverUIObj.SetActive(true);
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
}
