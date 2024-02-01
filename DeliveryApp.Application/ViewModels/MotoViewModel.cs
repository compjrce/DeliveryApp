using DeliveryApp.Domain.Entities;

namespace DeliveryApp.Application.ViewModels;

public class MotoViewModel
{
    public MotoViewModel(Guid id, DateTime createdOn, int year, string model, string licensePlate)
    {
        Id = id;
        CreatedOn = createdOn;
        Year = year;
        Model = model;
        LicensePlate = licensePlate;
    }

    public Guid Id { get; private set; }
    public DateTime CreatedOn { get; private set; }
    public int Year { get; private set; }
    public string Model { get; private set; }
    public string LicensePlate { get; private set; }

    public static MotoViewModel FromEntity(Moto moto) =>
        new MotoViewModel(moto.Id, moto.CreatedOn, moto.Year, moto.Model, moto.LicensePlate);

    public static List<MotoViewModel> FromEntity(List<Moto> listMoto)
    {
        List<MotoViewModel> list = new();

        foreach (var item in listMoto)
        {
            list.Add(new MotoViewModel(item.Id, item.CreatedOn, item.Year, item.Model, item.LicensePlate));
        }

        return list.ToList();
    }
}