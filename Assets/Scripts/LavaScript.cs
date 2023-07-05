using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaScript : MonoBehaviour
{
    [SerializeField]
    private GameObject playerPrefab;
    //private Player player;
    [SerializeField]
    private Transform spawn;
    private void Awake()
    {
        //player = playerPrefab.GetComponent<Player>();
        Player.player = Instantiate(playerPrefab, spawn.transform.position, Quaternion.identity).GetComponent<Player>();
        Player.saveZone = spawn;
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(Player.player.gameObject);
        Player.player = Instantiate(playerPrefab, Player.saveZone.position, Quaternion.identity).GetComponent<Player>();
        Debug.Log(other.gameObject);
        //other.transform.position = spawn.transform.position;
    }
}
