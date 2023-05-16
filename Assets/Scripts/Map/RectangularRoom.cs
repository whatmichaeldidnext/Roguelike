using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RectangularRoom
{
    public int x;
    public int y;
    public int width;
    public int height;

    public RectangularRoom(int x, int y, int width, int height) 
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public Vector2Int Centre() => new Vector2Int(x + width / 2, y + height / 2);

    /// <summary>
    /// Return the area of this room as a Bounds
    //// </summary>
    public Bounds GetBounds() => new Bounds(new Vector3(x, y, 0), new Vector3(width, height, 0));

    /// <summary>
    /// Return the area of this room as BoundsInt
    /// </summary>
    public BoundsInt GetBoundsInt() => new BoundsInt(new Vector3Int(x, y, 0), new Vector3Int(width, height, 0));

    ///<summary>
    /// Return True if this room over;laps with another RectangularRoom.
    ///</summary>
    public bool Overlaps(List<RectangularRoom> otherRooms)
    {
        foreach (RectangularRoom otherRoom in otherRooms)
        {
            if (GetBounds().Intersects(otherRoom.GetBounds()))
            {
                return true;
            }
        }
        return false;    
    }
}
