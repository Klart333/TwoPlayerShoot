using System.Collections;
using UnityEngine;
public class KillOnTouch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.WasPlayer())
        {
            StartCoroutine("KillPlayer", collision);
        }
    }

    public IEnumerator KillPlayer(Collision2D coll)
    {
        coll.collider.GetComponent<Animator>().SetTrigger("Död");
        yield return new WaitForSeconds(1);

        Win.Instance.OnWin(coll.gameObject);
    }
}
