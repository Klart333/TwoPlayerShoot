using UnityEngine;
public static class Collision2DExtensions
{
    public static bool WasPlayer(this Collision2D collision)
    {
        return collision.collider.GetComponent<GubbMovement>();
    }
}
