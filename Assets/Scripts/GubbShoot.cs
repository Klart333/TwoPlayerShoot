using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class GubbShoot : MonoBehaviour
{
    protected float bulletSpeed = 0;

    PhotonView photonView;

    protected bool bodgeInverted = false;

    virtual protected void Start()
    {
        photonView = PhotonView.Get(this);
        // Removed
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && photonView.IsMine)
        {
            photonView.RPC("Shoot", RpcTarget.All);
        }
    }
    [PunRPC]
    public void Shoot()
    {
        GameObject bull = PhotonNetwork.Instantiate("Prefabs/Bullet", transform.GetChild(0).position, Quaternion.identity);
        Rigidbody2D bullrb = bull.GetComponent<Rigidbody2D>();
        if (gameObject.transform.eulerAngles.y > 0)
        {
            bullrb.velocity = new Vector3(bulletSpeed, 0, 0);
            if (!bodgeInverted)
            {
                bull.GetComponent<SpriteRenderer>().flipX = true;
            }
        }
        else if (gameObject.transform.eulerAngles.y < 1)
        {
            bullrb.velocity = new Vector3(-bulletSpeed, 0, 0);
            if (bodgeInverted)
            {
                bull.GetComponent<SpriteRenderer>().flipX = true;
            }
        }
    }
}
