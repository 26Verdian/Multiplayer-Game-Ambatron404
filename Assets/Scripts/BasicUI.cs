using FishNet.Managing;
using UnityEngine;
using UnityEngine.UI;

public class NetworkUIFishNet : MonoBehaviour
{
    public Button hostButton;
    public Button clientButton;

    private NetworkManager networkManager;

    private void Awake()
    {
        networkManager = FindObjectOfType<NetworkManager>();

        hostButton.onClick.AddListener(StartHost);
        clientButton.onClick.AddListener(StartClient);
    }

    private void StartHost()
    {
        networkManager.ServerManager.StartHost();
    }

    private void StartClient()
    {
        networkManager.ClientManager.StartClient();
    }
}