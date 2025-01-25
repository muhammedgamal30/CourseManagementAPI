using CourseManagementAPI.Contollers;
using CourseManagementAPI.Data;
using CourseManagementAPI.Models;
using Moq;
using Xunit;

namespace CourseManagementAPI
{
  public class TrainerServiceTests
  {
    private readonly Mock<ApplicationDbContext> _mockContext;
    private readonly TrainersController _controller;

    public TrainerServiceTests()
    {
      _mockContext = new Mock<ApplicationDbContext>();
      _controller = new TrainersController(_mockContext.Object);
    }

    [Fact]
    public async Task GetTrainers_ReturnsListOfTrainers()
    {
      var result = await _controller.GetTrainers();
      Assert.IsType<List<Trainer>>(result.Value);
    }
  }

}
