using DeliveryApp.Domain.Enums;

namespace DeliveryApp.Domain.Entities;

public class DeliveryDriver : BaseEntity
{
    public DeliveryDriver(string name, string cNPJ, DateTime birthDate, string driverLicenseNumber, EDriverLicenseType driverLicenseType)
    {
        Name = name;
        CNPJ = cNPJ;
        BirthDate = birthDate;
        DriverLicenseNumber = driverLicenseNumber;
        DriverLicenseType = driverLicenseType;
    }

    public string Name { get; private set; }
    public string CNPJ { get; private set; }
    public DateTime BirthDate { get; private set; }
    public string DriverLicenseNumber { get; private set; }
    public EDriverLicenseType DriverLicenseType { get; private set; }
    public byte[] DriverLicenseImage { get; set; }
    public bool CategoryAEnabled => DriverLicenseType == EDriverLicenseType.A || DriverLicenseType == EDriverLicenseType.AB;
}