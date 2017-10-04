using Emergency_Skeleton.Enums;
using Emergency_Skeleton.Utils;

namespace Emergency_Skeleton.Models.Emergencies
{
    public class PublicOrderEmergency: BaseEmergency
    {
        private bool isSpecial;

        public PublicOrderEmergency(string description,ServiceAndEmergencyType type, EmergencyLevel emergencyLevel, RegistrationTime registrationTime, string isSpecial) : base(description, type,emergencyLevel, registrationTime)
        {
            this.IsSpecial = bool.Parse(isSpecial);
        }


        public bool IsSpecial
        {
            get { return this.isSpecial; }
            set { this.isSpecial = value; }
        }

    }
}
