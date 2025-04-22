using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveing : MonoBehaviour
{
    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
    }

    void Update()
    {
        transform.position = new Vector3(pos.x, pos.y, -Mathf.Sin(Time.time));
    }
}
