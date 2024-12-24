using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printer : MonoBehaviourPunCallbacks
{
    public int local = 0;
    public int opposite = 0;

    private PhotonView photonView;

    private void Start() {
        photonView = GetComponent<PhotonView>();
    }

    // привязывается к кнопке
    public void OnButtonClick() {
        local += 1;
        
        photonView.RPC(nameof(SyncScore), RpcTarget.Others, local);

        Debug.Log("Local is: " + local.ToString());
    }

    [PunRPC]
    private void SyncScore(int newGenValue) {
        opposite = newGenValue;
        Debug.Log("Opposite is: " + opposite.ToString());
    }
}
