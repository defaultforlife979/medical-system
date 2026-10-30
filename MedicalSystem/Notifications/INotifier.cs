using MedicalSystem.Users;

namespace MedicalSystem.Notifications
{
    internal interface INotifier
    {
        void Send(Patient patient, string message);
    }
}
