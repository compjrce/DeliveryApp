using AutoFixture;
using DeliveryApp.Application.InputModels;
using DeliveryApp.Application.Services;
using DeliveryApp.Domain.Entities;
using DeliveryApp.Domain.Repositories;
using Moq;
using Shouldly;

namespace DeliveryApp.Tests.Application.Services;

public class MotoServiceTests
{
    [Fact]
    public void InsertAsync_IsCalled_ReturnMotoViewModel()
    {
        // Given
        var moto = new Fixture().Create<MotoInputModel>();
        var repositoryMock = new Mock<IMotoServiceRepository>();
        var motoService = new MotoService(repositoryMock.Object);

        // When
        var result = motoService.InsertAsync(moto);

        // Then
        result.Result.Year.ShouldBe(moto.Year);
        result.Result.Model.ShouldBe(moto.Model);
        result.Result.LicensePlate.ShouldBe(moto.LicensePlate);

        repositoryMock.Verify(x => x.InsertAsync(It.IsAny<Moto>()), Times.Once);
    }
}