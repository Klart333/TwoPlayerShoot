using System.Collections;
using UnityEngine;
using Photon.Pun;
public class KillOnTouch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.WasPlayer() && !Win.Instance.gameover)
        {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            Win.Instance.gameover = true;
            StartCoroutine("KillPlayer", collision);
        }
    }

    [PunRPC]
    public IEnumerator KillPlayer(Collision2D coll)
    {
        coll.collider.GetComponent<Animator>().SetTrigger("Död");
        yield return new WaitForSeconds(1);

        Win.Instance.OnWin(coll.gameObject);
    }
}
