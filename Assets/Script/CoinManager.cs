using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    //�R�C��Prefab
    public GameObject coinObj;

    // Start is called before the first frame update
    void Start()
    {
        Coin();
    }

    // Update is called once per frame
    void Update()
    {
        ThrowCoins();
    }

    void Coin() //�R�C���������_���ɔz�u����
    {
        var coins = Random.Range(50, 100);

        for(int i = 0; i < coins; i++)
        {
            var x = Random.Range(-1f, 1f);
            var z = Random.Range(1f, 2.5f);
            var pos = new Vector3(x, 20, z);

            Instantiate(coinObj, pos, Quaternion.identity); //Prefab�𐶐�
        }
    }

    void ThrowCoins() //�R�C���𓊓�
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetKeyDown(KeyCode.Space) && !GameManager.instance.isGameOver)
        {
            if(Physics.Raycast(ray, out hit) && hit.collider.tag == "Wall")
            {
                Debug.Log(hit.point);
                Instantiate(coinObj, hit.point, Quaternion.identity);
                GameManager.instance.SubtractionCoin(); //�R�C�����Z
            }
        }
    }
}
