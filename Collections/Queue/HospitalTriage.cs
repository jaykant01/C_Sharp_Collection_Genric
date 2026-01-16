using System;
using System.Collections.Generic;

namespace Collections;

public class HospitalTriage
{
    private PriorityQueue<Patient, int> queue = new PriorityQueue<Patient, int>();

    // Add patient
    public void AddPatient(string name, int severity)
    {
      
        queue.Enqueue(new Patient { Name = name, Severity = severity }, -severity);
    }

    // Treat patients
    public void TreatPatients()
    {
        Console.WriteLine("Treatment Order:");
        while (queue.Count > 0)
        {
            Patient p = queue.Dequeue();
            Console.WriteLine($"{p.Name} (Severity: {p.Severity})");
        }
    }
}
