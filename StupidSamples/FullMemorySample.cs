﻿using System;
using System.Collections.Generic;

namespace StupidSamples
{
    public class FullMemorySample
    {
        public static void Test()
        {
            var list = new List<string>();
            try
            {
                while (true)
                {
                    list.Add(new string('x', int.MaxValue));
                }
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine(nameof(OutOfMemoryException));
                Console.WriteLine(list.Count);
                var bytes = GC.GetTotalAllocatedBytes();
                Console.WriteLine($"AllocatedBytes: { bytes / 1024.0 } kb");
            }
        }
    }
}
