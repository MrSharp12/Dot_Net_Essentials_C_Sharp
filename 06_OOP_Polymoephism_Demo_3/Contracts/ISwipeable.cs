﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_Polymoephism_Demo_3.Contracts
{
    public interface ISwipeable
    {
        void Accept();
        void Decline();
        void Swipe();
    }
}
