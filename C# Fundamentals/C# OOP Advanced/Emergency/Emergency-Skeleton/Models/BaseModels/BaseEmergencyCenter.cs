using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emergency_Skeleton.Enums;

namespace Emergency_Skeleton.Models
{
    public abstract class BaseEmergencyCenter
    {
        private string name;
        private ServiceAndEmergencyType type;
        private int amountOfMaximumEmergencies;
        private List<BaseEmergency> proceededEmergencies;

        protected BaseEmergencyCenter(string name, int amountOfMaximumEmergencies)
        {
            this.Name = name;
            this.Type = type;
            this.amountOfMaximumEmergencies = amountOfMaximumEmergencies;
            this.proceededEmergencies =new List<BaseEmergency>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }   
            set
            {
                this.name = value;
            }
        }

        public int AmountOfMaximumEmergencies
        {
            get
            {
                return this.amountOfMaximumEmergencies;
            }
            set
            {
                this.amountOfMaximumEmergencies = value;
            }
        }

        public ServiceAndEmergencyType Type { get => this.type; set => this.type = value; }

        public IReadOnlyList<BaseEmergency> ProceededEmergencies { get => proceededEmergencies;}        

        public bool IsForRetirement()
        {
            return this.amountOfMaximumEmergencies == 0;
        }

        public void ProceedEmergency(BaseEmergency emergency)
        {
            if (emergency == null)
            {
                throw new NullReferenceException();
            }

            this.amountOfMaximumEmergencies--;
            this.proceededEmergencies.Add(emergency);

        }
    }
}
