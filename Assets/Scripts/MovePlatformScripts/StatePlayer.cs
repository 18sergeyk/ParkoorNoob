using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePlayer : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
        if (other.GetComponentInParent<Player>())
        {
            Player.player.transform.parent = transform;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponentInParent<Player>())
        {
            Player.player.transform.parent = null;
        }
    }
}
