using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Emergency_Skeleton.Collection;
using Emergency_Skeleton.Enums;
using Emergency_Skeleton.Models;
using Emergency_Skeleton.Models.Emergencies;
using Emergency_Skeleton.Models.Services;
using Emergency_Skeleton.Utils;

namespace Emergency_Skeleton.Core
{
    public class EmergencyManagementSystem
    {
        private EmergencyRegister healthRegister;
        private EmergencyRegister propertyRegister;
        private EmergencyRegister orderRegister;
        private Queue<BaseEmergencyCenter> firemanServiceCenters;
        private Queue<BaseEmergencyCenter> medeServiceCenters;
        private Queue<BaseEmergencyCenter> policeServiceCenters;

        public EmergencyManagementSystem()
        {
            this.healthRegister = new EmergencyRegister();
            this.propertyRegister = new EmergencyRegister();
            this.orderRegister = new EmergencyRegister();
            this.firemanServiceCenters =new Queue<BaseEmergencyCenter>();
            this.medeServiceCenters = new Queue<BaseEmergencyCenter>();
            this.policeServiceCenters = new Queue<BaseEmergencyCenter>();
        }

        public string RegisterEmergency(string args)
        {
            var newEmergency = Factories.EmergencyFactory.Get(args);
            var fieldType = this.GetType().GetField($"{newEmergency.Type.ToString().ToLower()}Register", BindingFlags.Instance | BindingFlags.NonPublic);
            var inst = (EmergencyRegister)fieldType.GetValue(this);
            var addMethod = inst.GetType().GetMethod("EnqueueEmergency", BindingFlags.Instance | BindingFlags.Public| BindingFlags.NonPublic);
            addMethod.Invoke(inst, new object[] {newEmergency});
            

           //switch (newEmergency.Type)
           //{
           //    case ServiceAndEmergencyType.Property:
           //this.propertyRegister.EnqueueEmergency(newEmergency);
           //        break;
           //    case ServiceAndEmergencyType.Health:
           //this.healthRegister.EnqueueEmergency(newEmergency);
           //        break;
           //    case ServiceAndEmergencyType.Order:
           //this.propertyRegister.EnqueueEmergency(newEmergency);
           //        break;
           //}
            return $"Registered Public Property Emergency of level {newEmergency.EmergencyLevel} at {newEmergency.RegistrationTime}.";
        }

        public string RegisterFireServiceCenter(string name, int amountOfServices)
        {
            var newService = new FiremanServiceCenter(name, amountOfServices);
            return $"Registered Fire Service Emergency center – {name}.";
        }

        public string RegisterMedicalServiceCenter(string name, int amountOfServices)
        {
            var newService= new MedicalServiceCenter(name, amountOfServices);
            return $"Registered Medical Service Emergency center – {name}.";

        }

        public string RegisterPoliceServiceCenter(string name, int amountOfServices)
        {
            var newService= new PoliceServiceCenter(name, amountOfServices);
            return $"Registered Police Service Emergency center – {name}.";

        }

        public string ProcessEmergencies(ServiceAndEmergencyType typeToProceed)
        {
            Queue<BaseEmergencyCenter> center = new Queue<BaseEmergencyCenter>();
            EmergencyRegister register = new EmergencyRegister();
            switch (typeToProceed)
            {
                case ServiceAndEmergencyType.Property:
                    center = this.firemanServiceCenters;
                    register = this.propertyRegister;
                    break;
                case ServiceAndEmergencyType.Health:
                    center = this.medeServiceCenters;
                    register = healthRegister;
                    break;
                case ServiceAndEmergencyType.Order:
                    center = policeServiceCenters;
                    register = orderRegister;
                    break;
            }

            var emergenciesCount = register.CurrentSize;
            var serviceAttempts = center.Count+ center.Sum(c => c.AmountOfMaximumEmergencies);
            var counter = 0;
            for (int i = 0; i < emergenciesCount; i++)
            {
                if (serviceAttempts == 0)
                {
                    break;
                }

                var currentEm = register.DequeueEmergency();
                var currentService = center.Dequeue();
                currentService.ProceedEmergency(currentEm);
                serviceAttempts--;

                if (!currentService.IsForRetirement())
                {
                    center.Enqueue(currentService);
                }
   
                counter = i+1;

            }
            if (register.CurrentSize!=0)
            {
                return $"{typeToProceed} Emergencies left to process: {register.CurrentSize-counter}.";
            }
            else
            {
                return $"Successfully responded to all {typeToProceed} emergencies.";
            }
            
        }

        public string EmergencyReport()
        {
            return null;
        }
    }
}
