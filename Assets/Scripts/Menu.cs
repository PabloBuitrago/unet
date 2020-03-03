using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Menu : MonoBehaviour {

    MyNetworkDiscovery myNetworkDiscovery;

    void Awake()
    {
        myNetworkDiscovery = FindObjectOfType<MyNetworkDiscovery>();
    }

    void Start()
    {
        StopDiscovery();
    }

    public void CrearUnaPartida()
    {
        StopDiscovery();
        myNetworkDiscovery.StartAsServer();
        NetworkManager.singleton.StartHost();
    }

    public void UnirseAUnaPartida()
    {
        StopDiscovery();
        myNetworkDiscovery.StartAsClient();
    }

    private void StopDiscovery()
    {
        if (myNetworkDiscovery.running)
        {
            myNetworkDiscovery.StopBroadcast();
        }
    }
}
