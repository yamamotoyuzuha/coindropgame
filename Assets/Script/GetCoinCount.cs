using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoinCount : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Debug.Log("�R�C�����擾");

            GameManager.instance.AddCoin(); //�R�C�������Z
            Debug.Log("���݂̃R�C��" + GameManager.instance.currentCoin);

            //�R�C�������Z������폜����
            Destroy(collision.gameObject);
        }
    }
}
