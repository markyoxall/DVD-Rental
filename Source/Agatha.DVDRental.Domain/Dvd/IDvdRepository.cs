﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agatha.DVDRental.Domain.Dvd
{
    public interface IDvdRepository
    {
        Dvd FindBy(int dvdId);
    }
}
