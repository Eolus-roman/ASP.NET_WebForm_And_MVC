﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHouse
{
    public interface ICreate
    {
        Television CreateTelevision();
        Radioreceiver CreateRadioreceiver();
        Fridge CreateFridge();
    }
}