using UnityEngine;

public static class RandomPlus
{
    /// <summary>
    /// Get a random position within the box collider.
    /// </summary>
    /// <param name="b">this box collider, to get position in collider in.</param>
    /// <param name="x">should x position be randomized within box collider.</param>
    /// <param name="y">should y position be randomized within box collider.</param>
    /// <param name="z">should z position be randomized within box collider.</param>
    /// <returns>returns random position in box collider.</returns>
    public static Vector3 RandomPositionInBox(this BoxCollider b, bool x = true, bool y = true, bool z = true)
    {
        Vector3 pos;
        pos.x = x ? Random.Range(- b.size.x / 2, b.size.x / 2) : 0;
        pos.y = y ? Random.Range(- b.size.y / 2, b.size.y / 2) : 0;
        pos.z = z ? Random.Range(- b.size.z / 2, b.size.z / 2) : 0;

        pos = Vector3.Scale(pos, b.transform.localScale);
        pos += b.center + b.transform.position;
        
        return pos;
    }

    /// <summary>
    /// Create a random string using Unity's Random function.
    /// </summary>
    /// <param name="s">this string, that will be used to return a string to, pass a non empty string to concat.</param>
    /// <param name="length">length of new random string to add on.</param>
    /// <param name="mixCase">should there be mixed case, otherwise it will return lower case.</param>
    /// <returns>returns the new randomized string.</returns>
    public static string RandomString(this string s, int length = 1, bool mixCase = true)
    {
        for (int i = 0; i < length; i++)
        {
            char c = (char)(mixCase ? Random.Range(0, 1f) > 0.5f ? 'A' : 'a' : 'a' + Random.Range(0, 26));
            s += c;
        }
        return s;
    }
}
