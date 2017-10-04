using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergency_Skeleton.Models.Services
{
    public class FiremanServiceCenter: BaseEmergencyCenter
    {
        public FiremanServiceCenter(string name, int amountOfMaximumEmergencies) : base(name, amountOfMaximumEmergencies)
        {
        }

        
    }
}
