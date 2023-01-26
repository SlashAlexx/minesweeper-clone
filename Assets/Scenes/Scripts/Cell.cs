using UnityEngine;

public struct Cell
{
    public enum Type
    {
        Invalid,
        Empty,
        Mine,
        Value,
    }

    public Vector3Int position;
    public Type type;
    public int value;
    public bool revealed;
    public bool flagged;
    public bool exploded;

}
