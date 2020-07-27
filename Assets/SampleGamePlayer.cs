using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SampleGamePlayer : MonoBehaviourPunCallbacks
{


    // Update is called once per frame
    void Update()
    {
        if (photonView.IsMine)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            transform.position += new Vector3(x * 0.1f, y * 0.1f, 0f);
        }
    }
}
