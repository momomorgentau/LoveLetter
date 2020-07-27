using UnityEngine;
using System.Collections;
using Photon.Pun;
using Photon.Realtime;

public class PhotonManager : MonoBehaviourPunCallbacks
{

    // Start is called before the first frame update
    void Start()
    {
        //PhotonSeverSettinsに設定した内容を使ってマスターサーバに接続
        PhotonNetwork.ConnectUsingSettings();

    }

    //マスターサーバに接続したときに呼ばれるコールバック
    public override void OnConnectedToMaster()
    {
        Debug.Log("マスターサーバへ接続成功");
        PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions(), TypedLobby.Default);
    }


    //マッチングが成功したときに呼ばれるコールバック
    public override void OnJoinedRoom()
    {
        var v = new Vector3(Random.Range(-3f, 3f), Random.Range(-3f, 3f));
        //PhotonNetwork.Instantiate("GamePlayer", v, Quaternion.identity);
        
    }
}
