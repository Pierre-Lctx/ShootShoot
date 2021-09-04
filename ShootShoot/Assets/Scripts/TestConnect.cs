﻿using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class TestConnect : MonoBehaviourPunCallbacks
{
    private void Start()
    {

        print("Connecting to server.");
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        print("Game Version : " + MasterManager.GameSettings.GameVersion);
        PhotonNetwork.ConnectUsingSettings();
        print("Fin Start");
    }

    public override void OnConnectedToMaster()
    {
        print("Connected to server.");
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        print("Disconnected from server for reason " + cause.ToString());
    }
}
