﻿using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class TestConnect : MonoBehaviourPunCallbacks
{
    private void Start()
    {

        print("Connecting to server.");
        PhotonNetwork.GameVersion = "0.0.1";
        PhotonNetwork.ConnectUsingSettings();
        
    }

    public void OnConnectedToMaster()
    {
        print("Connected to server.");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        print("Disconnected from server for reason: " + cause.ToString() + ".");
    }
}
