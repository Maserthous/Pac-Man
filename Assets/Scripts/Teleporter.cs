using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

    public float offset;

    private Transform trans;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="Player")
        {
            Vector3 pos = other.gameObject.GetComponent<Transform>().position;

            if (pos.x >= 0)
            {
                pos.x = -pos.x + offset;
            }
            else
            {
                pos.x = -pos.x - offset;
            }

            other.gameObject.GetComponent<Transform>().position = pos;
        }
    }
}
