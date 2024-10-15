using Reactive.Bindings;
using System.ComponentModel.DataAnnotations;

namespace NestedRPObjValidationSample.Models;

class SomeModel
{
    public ICollection<SomeEntity> SomeValues { get; } = [];
}

class SomeEntity
{
    [Required(ErrorMessage = "A is required.")]
    public ValidatableReactiveProperty<string> A { get; set; }
    [Required(ErrorMessage = "B is required.")]
    public ValidatableReactiveProperty<string> B { get; set; }

    public SomeEntity()
    {
        A = ValidatableReactiveProperty.CreateFromDataAnnotations("", () => A);
        B = ValidatableReactiveProperty.CreateFromDataAnnotations("", () => B);
    }
}
