using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoinCount : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Debug.Log("コインを取得");

            GameManager.instance.AddCoin(); //コインを加算
            Debug.Log("現在のコイン" + GameManager.instance.currentCoin);

            //コインを加算したら削除する
            Destroy(collision.gameObject);
        }
    }
}
