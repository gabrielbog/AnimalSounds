using AnimalSounds;

namespace AnimalSounds.UnitTest
{
    public class FelineTest
    {
        [Fact]
        public void GetType_String_ReturnsFeline()
        {
            //Arrange
            var expectedType = "Feline";
            var feline = new Feline();

            //Act
            var type = feline.GetType();

            //Assert
            Assert.Equal(expectedType, type);
        }

        [Fact]
        public void GetSound_String_ReturnsHiss()
        {
            //Arrange
            var expectedSound = "Hiss";
            var feline = new Feline();

            //Act
            var sound = feline.GetSound();

            //Assert
            Assert.Equal(expectedSound, sound);
        }
    }
}