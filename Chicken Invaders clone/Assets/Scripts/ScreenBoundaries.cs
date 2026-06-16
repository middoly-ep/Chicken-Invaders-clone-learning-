using UnityEngine;

public static class ScreenBoundaries
{
    public static Vector2 GetBottomLeft()
    {
        return Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
    }
    public static Vector2 GetTopRight()
    {
        return Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
    }
}
