using Bookify.Application.Abtractions.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Application.Bookings.GetBooking;
public record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;
