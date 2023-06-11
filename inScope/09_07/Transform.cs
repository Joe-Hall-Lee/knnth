using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09_00
{
    class Transform
    {
        /// <summary>
        /// The position of the transform
        /// </summary>
        public Vector2 Position { get; set; }

        public Transform()
        {
            Position = new Vector2(0, 0);
        }
    }
}
