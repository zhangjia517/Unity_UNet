using Prototype.NetworkLobby;
using UnityEngine;
using UnityEngine.Networking;

public class LobbyHookCustom : LobbyHook
{
    public override void OnLobbyServerSceneLoadedForPlayer(NetworkManager manager, GameObject lobbyPlayer, GameObject gamePlayer)
    {
    }
}