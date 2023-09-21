using FirstResponsiveWeb.Models;
using System.ComponentModel.DataAnnotations;
using Xunit;

public class AgeThisYearModelTests
{
    [Fact]
    public void CalculateAge_CorrectBirthYear_ReturnsCorrectAge()
    {
        // Arrange
        var model = new AgeThisYearModel { BirthYear = 1980 };

        // Act
        int age = model.ageThisYear();

        // Assert
        Assert.Equal(43, age); // Replace with the actual expected age.
    }

    [Fact]
    public void Validation_InvalidData_ReturnsValidationError()
    {
        // Arrange
        var model = new AgeThisYearModel { Name = null, BirthYear = 1980 };
        var context = new ValidationContext(model);
        var results = new List<ValidationResult>();

        // Act
        bool isValid = Validator.TryValidateObject(model, context, results, true);

        // Assert
        Assert.False(isValid);
        Assert.Contains(results, r => r.ErrorMessage == "Please enter Name.");
    }

}