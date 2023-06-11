using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_00
{
    static class MyTime
    {
        /// <summary>
        /// Start time of the frame
        /// </summary>
        private static DateTime startTime;

        /// <summary>
        /// Endtime of the frame
        /// </summary>
        private static DateTime endTime;

        /// <summary>
        /// Deltatime, this variable can be used to make framerate independent movement
        /// </summary>
        public static float DeltaTime { get; private set; }

        /// <summary>
        /// Calculates DeltaTime
        /// </summary>
        public static void CalcDeltaTime()
        {
            startTime = DateTime.Now;

            if (endTime.Ticks != 0)
            {
                DeltaTime = (startTime.Ticks - endTime.Ticks) / 10000000f;
            }

            endTime = startTime;
        }
    }
}
