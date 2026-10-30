using MedicalSystem.Users;

namespace MedicalSystem.Notifications
{
    internal class EmailNotifier : INotifier
    {
        public void Send(Patient patient, string message)
        {
            Console.WriteLine($"Email на адрес {patient.Email}: {message}");
        }
    }
}
