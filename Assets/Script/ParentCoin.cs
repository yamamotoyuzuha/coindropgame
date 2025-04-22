using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCoin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Table")
        {
            this.gameObject.transform.parent = other.transform.GetChild(0).transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Table")
        {
            this.gameObject.transform.parent = null;
        }
    }
}
