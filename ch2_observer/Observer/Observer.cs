﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_observer
{
    public interface Observer
    {
        void update(float temperature, float humidity, float pressure);
    }
}
