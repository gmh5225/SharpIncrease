﻿using System;

namespace SharpBigg
{
    internal class Information
    {
        public static void Banner()
        {
            var bannerText = @"
  ____  _                     ___                                    
 / ___|| |__   __ _ _ __ _ __|_ _|_ __   ___ _ __ ___  __ _ ___  ___ 
 \___ \| '_ \ / _` | '__| '_ \| || '_ \ / __| '__/ _ \/ _` / __|/ _ \
  ___) | | | | (_| | |  | |_) | || | | | (__| | |  __/ (_| \__ \  __/
 |____/|_| |_|\__,_|_|  | .__/___|_| |_|\___|_|  \___|\__,_|___/\___|
                        |_|                                          

            Mert Daş     @merterpreter

";
            Console.WriteLine(bannerText);
        }
    }
}