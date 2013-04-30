﻿using System;

namespace Agatha.DVDRental.Subscription.Model.Subscriptions
{
    public class Package  // Value object
    {
        public int DiscsOutAtSameTime { get; set; }

        public int NewReleasesAMonth { get; set; }

        public DateTime StartDate { get; set; }

        public Money MonthlyCost { get; set; }

        public bool IsAllowedAHoliday()
        {
            return true;
        }

        public bool CanRent(Film film)
        {
            // Not this month
            // Too many Dvds currently out
            // Used up all new releases this month
            // too many new releases out at the same time

            return true;
        }

        public bool IsADowngradeFrom(Package package)
        {
            return false;
        }
    }
}
