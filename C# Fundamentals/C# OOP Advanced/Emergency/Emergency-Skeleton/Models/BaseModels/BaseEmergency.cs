namespace Emergency_Skeleton.Models
{
    using Enums;
    using Utils;

    public abstract class BaseEmergency
    {
        private string description;
        private ServiceAndEmergencyType type;
        private EmergencyLevel emergencyLevel;
        private RegistrationTime registrationTime;

        protected BaseEmergency(string description,ServiceAndEmergencyType type, EmergencyLevel emergencyLevel, RegistrationTime registrationTime)
        {
            this.Description = description;
            this.EmergencyLevel = emergencyLevel;
            this.type = type;
            this.RegistrationTime = registrationTime;
        }

        public string Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        public EmergencyLevel EmergencyLevel
        {
            get
            {
                return this.emergencyLevel;
            }
            set
            {
                this.emergencyLevel = value;
            }
        }

        public RegistrationTime RegistrationTime
        {
            get
            {
                return this.registrationTime;
            }
            set
            {
                this.registrationTime = value;
            }
        }

        public ServiceAndEmergencyType Type { get => this.type; set => this.type = value; }
    }
}
