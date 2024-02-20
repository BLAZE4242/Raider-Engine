using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raider_Engine
{
    #region Vectors

    /// <summary>
    /// Vector2
    /// </summary>
    public class Vector2
    {
        public float x;
        public float y;

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 firstVector2, Vector2 secondVector2)
        {
            return new Vector2(firstVector2.x + secondVector2.x, firstVector2.y + secondVector2.y);
        }

        public static Vector2 operator -(Vector2 firstVector2, Vector2 secondVector2)
        {
            return new Vector2(firstVector2.x + secondVector2.x, firstVector2.y + secondVector2.y);
        }
    }

    public class Vector2Int
    {
        public int x;
        public int y;

        public Vector2Int(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2Int operator +(Vector2Int firstVector2, Vector2Int secondVector2)
        {
            return new Vector2Int(firstVector2.x + secondVector2.x, firstVector2.y + secondVector2.y);
        }

        public static Vector2Int operator -(Vector2Int firstVector2, Vector2Int secondVector2)
        {
            return new Vector2Int(firstVector2.x + secondVector2.x, firstVector2.y + secondVector2.y);
        }
    }

    /// <summary>
    /// Vector3
    /// </summary>
    public class Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3 operator +(Vector3 firstVector3, Vector3 secondVector3)
        {
            return new Vector3(firstVector3.x + secondVector3.x, firstVector3.y + secondVector3.y, firstVector3.z + secondVector3.z);
        }

        public static Vector3 operator -(Vector3 firstVector3, Vector3 secondVector3)
        {
            return new Vector3(firstVector3.x + secondVector3.x, firstVector3.y + secondVector3.y, firstVector3.z + secondVector3.z);
        }
    }

    public class Vector3Int
    {
        public int x;
        public int y;
        public int z;

        public Vector3Int(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3Int operator +(Vector3Int firstVector3Int, Vector3Int secondVector3Int)
        {
            return new Vector3Int(firstVector3Int.x + secondVector3Int.x, firstVector3Int.y + secondVector3Int.y, firstVector3Int.z + secondVector3Int.z);
        }

        public static Vector3Int operator -(Vector3Int firstVector3Int, Vector3Int secondVector3Int)
        {
            return new Vector3Int(firstVector3Int.x + secondVector3Int.x, firstVector3Int.y + secondVector3Int.y, firstVector3Int.z + secondVector3Int.z);
        }
    }

    #endregion
}
