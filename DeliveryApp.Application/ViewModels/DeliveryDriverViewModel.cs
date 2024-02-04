using DeliveryApp.Domain.Entities;
using DeliveryApp.Domain.Enums;

namespace DeliveryApp.Application.ViewModels;

public class DeliveryDriverViewModel
{
    public DeliveryDriverViewModel(Guid id, DateTime createdOn, string name, string cNPJ, DateTime birthDate, string driverLicenseNumber, EDriverLicenseType driverLicenseType, string driverLicenseImage)
    {
        Id = id;
        CreatedOn = createdOn;
        Name = name;
        CNPJ = cNPJ;
        BirthDate = birthDate;
        DriverLicenseNumber = driverLicenseNumber;
        DriverLicenseType = driverLicenseType;
        DriverLicenseImage = driverLicenseImage;
    }

    public Guid Id { get; private set; }
    public DateTime CreatedOn { get; private set; }
    public string Name { get; private set; }
    public string CNPJ { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string DriverLicenseNumber { get; private set; }
    public EDriverLicenseType DriverLicenseType { get; private set; }
    public string DriverLicenseImage { get; private set; }

    public static DeliveryDriverViewModel FromEntity(DeliveryDriver deliveryDriver) =>
        new(deliveryDriver.Id,
            deliveryDriver.CreatedOn,
            deliveryDriver.Name,
            deliveryDriver.CNPJ,
            deliveryDriver.BirthDate,
            deliveryDriver.DriverLicenseNumber,
            deliveryDriver.DriverLicenseType,
            deliveryDriver.DriverLicenseImage);
}