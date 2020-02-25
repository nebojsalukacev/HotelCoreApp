using System;

namespace Hotel.Model.Common
{
    public interface IHotel
    {
        Guid Id { get; set; }
        string Name { get; set; }
        int NumberOfStars { get; set; }
    }
}
