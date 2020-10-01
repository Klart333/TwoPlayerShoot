using System.Collections;
using UnityEngine;
using Photon.Pun;
public class KillOnTouch : MonoBehaviour
{
    PhotonView photonView;

    private void Awake()
    {
        photonView = PhotonView.Get(this);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.WasPlayer())
        {
            photonView.RPC("CallMyRoutine", RpcTarget.All, collision);
        }
    }

    [PunRPC]
    public void CallMyRoutine(Collision2D coll)
    {
        StartCoroutine("KillPlayer", coll);
    }

    public IEnumerator KillPlayer(Collision2D coll)
    {
        coll.collider.GetComponent<Animator>().SetTrigger("Död");
        yield return new WaitForSeconds(1);

        Win.Instance.OnWin(coll.gameObject);
    }
}
