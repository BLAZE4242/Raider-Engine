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
        // TODO add variable for keeping track of which verticies connect to which

        public World(Vector3[] vertices)
        {
            this.vertices = vertices;
        }
    }
}
