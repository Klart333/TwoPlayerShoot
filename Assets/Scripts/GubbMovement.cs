using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class GubbMovement : MonoBehaviour
{
    protected string upKey;
    protected string downKey;
    protected string leftKey;
    protected string rightKey;

    [SerializeField]
    float speed = 5;

    PhotonView playerView;

    protected int bodgeP2;

    protected virtual void Start()
    {
        playerView = GetComponent<PhotonView>();
    }

    protected virtual void Update()
    {
        if (playerView.IsMine)
        {
            Vector3 movement = new Vector3();
            if (Input.GetKey(upKey))
            {
                movement += Vector3.up;
            }
            if (Input.GetKey(downKey))
            {
                movement += Vector3.down;
            }
            if (Input.GetKey(leftKey))
            {
                movement += Vector3.left;
            }
            if (Input.GetKey(rightKey))
            {
                movement += Vector3.right;
            }
            if (Input.anyKey)
            {
                if (movement.x < 0)
                {
                    gameObject.transform.eulerAngles = new Vector3(0, 180 - bodgeP2, 0);
                }
                else if (movement.x > 0)
                {
                    gameObject.transform.eulerAngles = new Vector3(0, 0 + bodgeP2, 0);
                }
                transform.position += movement * Time.deltaTime * speed;
            }
        }
        
    }
}
