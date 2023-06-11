using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _09_00
{
    public class Transform
    {
        /// <summary>
        /// The position of the transform
        /// </summary>
        public Vector2 Position { get; set; }

        /// <summary>
        /// The transform's constructor
        /// </summary>
        public Transform()
        {
            Position = new Vector2(0, 0);
        }

        /// <summary>
        /// Moves the transform in the direction and distance of translation
        /// </summary>
        /// <param name="translation"></param>
        public void Translate(Vector2 translation)
        {
            if (!float.IsNaN(translation.X) && !float.IsNaN(translation.Y))
            {
                Position += translation;
            }
        }
    }
}