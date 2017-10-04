using System;
using System.Collections.Generic;
using System.Linq;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventList = new Dictionary<string, Event>();

            for (;;)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                if (input[0] == "Time")
                {
                    break;
                }
                bool isItValid = true;
                for (int i = 0; i < input.Count; i++)
                {
                    int blbal;
                    if (i == 1)
                    {
                        if (input[i][0] != '#')
                        {
                            isItValid = false;
                            break;
                        }
                    }
                    else if (i == 0)
                    {
                        if (!int.TryParse(input[0], out blbal))
                        {
                            isItValid = false;
                            break;
                        }
                    }
                    else
                    {
                        if (input[i][0] != '@')
                        {
                            isItValid = false;
                            break;
                        }
                    }
                }
                var uniqueNumber = input[0];
                var nameOfEvent = input[1];

                if (isItValid)
                {

                    if (!eventList.ContainsKey(uniqueNumber))
                    {
                        var currentEvent = new Event
                        {
                            ID = uniqueNumber,
                            NameOfEvent = nameOfEvent,
                            Participants = new List<string>()
                        };
                        foreach (var item in input.Skip(2))
                        {
                            currentEvent.Participants.Add(item);
                        }
                        eventList[uniqueNumber] = currentEvent;
                    }
                    else if (eventList.ContainsKey(uniqueNumber))
                    {
                        if (eventList[uniqueNumber].NameOfEvent == nameOfEvent)
                        {
                            foreach (var item in input.Skip(2))
                            {
                                if (!eventList[uniqueNumber].Participants.Contains(item))
                                {
                                    eventList[uniqueNumber].Participants.Add(item);

                                }
                            }
                        }
                    }
                }
            }
            if (eventList.Any())
            {
                foreach (var eventisimo in eventList.OrderByDescending(e => e.Value.Participants.Count).ThenBy(e => e.Key))
                {
                    Console.WriteLine($"{eventisimo.Value.NameOfEvent.Remove(0, 1)} - {eventisimo.Value.Participants.Count}");
                    foreach (var item in eventisimo.Value.Participants.OrderBy(p => p))
                    {
                        Console.WriteLine(item);
                    }
                }
            }

        }
    }

    class Event
    {
        public string ID { get; set; }
        public string NameOfEvent { get; set; }
        public List<string> Participants { get; set; }
    }
}
