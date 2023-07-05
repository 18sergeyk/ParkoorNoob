using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveZone : MonoBehaviour
{
    private bool isSaving = true;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<Player>() && isSaving == true)
        {
            Player.saveZone = this.transform;
            isSaving = false;
        }
    }
}
