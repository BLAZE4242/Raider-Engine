using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raider_Engine
{
    class World
    {
        public Vector3[] vertices;
        public Vector2Int[] edgeConnections;

        public World(Vector3[] vertices, Vector2Int[] edgesConnection)
        {
            this.vertices = vertices;
            this.edgeConnections = edgesConnection;
        }
    }
}
