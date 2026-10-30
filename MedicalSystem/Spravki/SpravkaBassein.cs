using MedicalSystem.Interfaces;
using MedicalSystem.Users;

namespace MedicalSystem.Spravki
{
    internal class SpravkaBassein : ISpravka
    {
        public string SpravkaName { get; set; } = "";
        public Patient Patient { get; set; } = null!;
        public decimal Price { get; set; }
        public int ValidMonths { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Spravka Name: {SpravkaName}");
            Console.WriteLine($"Patient: {Patient.Name} {Patient.Surname}");
            Console.WriteLine($"Blood Type: {Patient.BloodType}");
            Console.WriteLine($"Price: {CalculatePrice():F2}");
            Console.WriteLine($"Valid for: {ValidMonths} month(s)");
        }

        public decimal CalculatePrice() => Price;

        public string GetShortInfo() => $"{SpravkaName}: {CalculatePrice():F2}";
    }
}
