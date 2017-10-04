using Emergency_Skeleton.Enums;
using Emergency_Skeleton.Utils;

namespace Emergency_Skeleton.Models.Emergencies
{
    public class PublicPropertyEmergency: BaseEmergency
    {
        private int propertyDamage;

        public PublicPropertyEmergency(string description,ServiceAndEmergencyType type, EmergencyLevel emergencyLevel, RegistrationTime registrationTime,string propertyDmg) : base(description,type, emergencyLevel, registrationTime)
        {
            this.PropertyDamage = int.Parse(propertyDmg);
        }

        public int PropertyDamage
        {
            get { return this.propertyDamage; }
            set { this.propertyDamage = value; }
        }

    }
}
