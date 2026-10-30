using MedicalSystem.Users;

namespace MedicalSystem.Notifications
{
    internal class SmsNotifier : INotifier
    {
        public void Send(Patient patient, string message)
        {
            Console.WriteLine($"SMS на номер {patient.PhoneNumber}: {message}");
        }
    }
}
