﻿using Bookify.Application.Abtractions.Messaging;

namespace Bookify.Application.Bookings.ReserveBooking;
public record ReserveBookingCommand(
    Guid ApartmentId,
    Guid UserId,
    DateOnly StartDate,
    DateOnly EndDate
    ) : ICommand<Guid>;
