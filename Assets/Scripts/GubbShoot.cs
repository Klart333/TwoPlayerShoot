using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class GubbShoot : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    protected float bulletSpeed = 0;

    PhotonView playerView;

    protected bool bodgeInverted = false;

    virtual protected void Start()
    {
        playerView = GetComponent<PhotonView>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && playerView.IsMine)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bull = Instantiate(bullet, transform.GetChild(0).position, Quaternion.identity);
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
