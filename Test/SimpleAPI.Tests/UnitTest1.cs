using SimpleAPI;
namespace SimpleAPI.Tests;

public class UnitTest1
{
    ValuesController valuesController=new ValuesController(); // Arrange
    [Fact]
    public void GetReturnCollectNumber()
    {        
        // Given
    var getValue = valuesController.Get(1);  // Act
        // When
        Assert.Equal("Amar",getValue);  // Assert
        // Then
       
    }
}