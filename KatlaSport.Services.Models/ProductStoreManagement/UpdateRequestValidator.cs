using FluentValidation;

namespace KatlaSport.Services.ProductStoreManagement
{
    /// <summary>
    /// Represent a validator for <see cref="UpdateRequest"/> class.
    /// </summary>
    public class UpdateRequestValidator : AbstractValidator<UpdateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRequestValidator"/> class.
        /// </summary>
        public UpdateRequestValidator()
        {
            RuleFor(r => r.Amount).GreaterThan(0);
            RuleFor(r => r.ProductStoreId).GreaterThan(0);
        }
    }
}
