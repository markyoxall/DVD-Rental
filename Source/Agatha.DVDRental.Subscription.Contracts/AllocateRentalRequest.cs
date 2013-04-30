﻿using NServiceBus;

namespace Agatha.DVDRental.Subscription.Contracts
{
    public class AllocateRentalRequest : ICommand
    {
        public int SubscriptionId { get; set; }

        public int FilmId { get; set; }
    }
}
