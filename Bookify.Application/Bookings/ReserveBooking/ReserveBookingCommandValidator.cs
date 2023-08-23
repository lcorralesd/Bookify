using FluentValidation;

namespace Bookify.Application.Bookings.ReserveBooking;
public class ReserveBookingCommandValidator : AbstractValidator<ReserveBookingCommand>
{
    public ReserveBookingCommandValidator()
    {
        RuleFor(x => x.UserId).NotEmpty()
            .WithMessage("User Id is required");

        RuleFor(c => c.ApartmentId).NotEmpty()
            .WithMessage("Apartment Id is required");

        RuleFor(c => c.StartDate)
            .LessThan(c => c.EndDate);
    }
}
