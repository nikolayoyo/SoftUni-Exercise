using Emergency_Skeleton.Enums;
using Emergency_Skeleton.Utils;

namespace Emergency_Skeleton.Models.Emergencies
{
    public class PublicHealthEmergency:BaseEmergency
    {
        private int numberOfCasualties;

        public PublicHealthEmergency(string description,ServiceAndEmergencyType type, EmergencyLevel emergencyLevel, RegistrationTime registrationTime, string numberOfCasulaties) : base(description, type, emergencyLevel, registrationTime)
        {
            this.numberOfCasualties = int.Parse(numberOfCasulaties);
        }

        public int NumberOfCasualties
        {
            get { return this.numberOfCasualties; }
            set { this.numberOfCasualties = value; }
        }

    }
}
