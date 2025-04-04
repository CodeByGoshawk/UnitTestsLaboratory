//using Laboratory;
//using Moq;

//namespace Tester;

//[TestClass]
//public class TestsClass
//{
//    [TestMethod]
//    public void Div_ValidInput_ReturnCorrect()
//    {
//        //Arrange
//        decimal a = 1;
//        decimal b = 2;
//        decimal expected = 0.5M;

//        //Act
//        var sum = new MathService().Div(a, b);

//        //Assert
//        Assert.AreEqual(expected, sum);
//    }

//    [TestMethod]
//    public void Div_ZeroInput_DivToZeroException()
//    {
//        //Arrange
//        decimal a = 1;
//        decimal b = 0;

//        //Act and Assert
//        Assert.Throws<DivideByZeroException>(() => new MathService().Div(a, b));
//    }

//    [TestMethod]
//    public void X()
//    {
//        //Arrange 
//        decimal a = 2;
//        decimal b = 1;
//        decimal excpected = 2;
//        var mockWriter = new Mock<IWriter>();
//        var mathService = new MathService();
//        var processService = new ProcessService(mockWriter.Object, mathService);

//        Assert.Fail("Amir");

//        //Act
//        processService.Do(a, b);
//        mockWriter.Verify(writer => writer.Write("test.txt", excpected.ToString()));
//    }
//}