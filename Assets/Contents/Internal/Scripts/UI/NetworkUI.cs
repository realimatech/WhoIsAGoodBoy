﻿using Network;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NetworkUI : MonoBehaviour
{
    [SerializeField] private GameObject connectingUI;
    [SerializeField] private GameObject connectedUI;
    [SerializeField] private GameObject searchingUI;

    [SerializeField] private TVAlertUI popupAlert;

    [SerializeField] private TMP_InputField in_RoomName;

    private void OnLobbyConnected()
    {
        connectingUI?.SetActive(false);
        connectedUI?.SetActive(true);
    }

    public void UICallConnection()
    {
        connectingUI?.SetActive(true);
        NetworkManager.ConnectService();
        NetworkManager.Service.connectionTimeoutEvent += OnConnectionTimeout;
        NetworkManager.Service.lobbyConnectedEvent += OnLobbyConnected;
        NetworkManager.Service.roomNotFoundEvent += OnRoomNotFound;
    }

    private void OnConnectionTimeout()
    {
        popupAlert?.PlayRoomAlert("Demorou muito\nConectar?",
            //Ok
            () =>
            {
                UICallConnection();
            },
            //Cancel
            () =>
            {
                CloseTV();
                GetComponentInParent<MainMenuUI>().PlayCut(6);
            });
    }

    public void JoinPressed()
    {
        connectedUI.SetActive(false);
        searchingUI?.SetActive(true);
        NetworkManager.JoinRoom(in_RoomName.text);
    }

    private void OnRoomNotFound(string name)
    {
        popupAlert?.PlayRoomAlert(name,
            //Ok
            () =>
            {
                NetworkManager.Service.CreateRoom(name);
            },
            //Cancel
            () =>
            {
                searchingUI?.SetActive(false);
                connectedUI.SetActive(true);
            });
    }

    public void CloseTV()
    {
        connectingUI?.SetActive(false);
        connectedUI?.SetActive(false);
        searchingUI?.SetActive(false);
        popupAlert?.Close();
        NetworkManager.Service.lobbyConnectedEvent -= OnLobbyConnected;
        NetworkManager.Service.roomNotFoundEvent -= OnRoomNotFound;
        NetworkManager.DisconnectService();
    }
}
