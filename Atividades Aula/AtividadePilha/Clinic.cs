using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadePilha
{
    internal class Clinic
    {
        public Stack<int> AvailableNumbers { get; set; }
        public Stack<Attendance> Attendances { get; set; } = [];

        public Clinic()
        {
            AvailableNumbers = [];
            int availableNumbers = 15;
            for (int i = 0; i < availableNumbers; i++)
            {
                AvailableNumbers.Push(i); 
            }
        }

        public void GenerateAttendances()
        {
            Random random = new();
            int attendanceNumbers = random.Next(5, 10);
            for (int i = 1; i <= attendanceNumbers; i++)
            {
                Thread.Sleep(random.Next(1000, 5000));
                Attendance attendance = new ()
                {
                    Id = i,
                    ArrivalTime = DateTime.Now
                };
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Consulta: {attendance.Id} chegou às: {attendance.ArrivalTime}");

                Attendances.Push(attendance);
            }
        }

        public Attendance Answer(string doctor)
        {
            while (AreWaitingAttendances())
            {
                Attendance attendance = Attendances.Pop();
                attendance.Doctor = doctor;
                attendance.StartTime = DateTime.Now;
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Iniciado atendimento da consulta {attendance.Id} às {attendance.StartTime} pelo doutor {attendance.Doctor}");


                return attendance;
            }

            return null!;
        }

        public void EndAttendance(Attendance attendance)
        {
            attendance.EndTime = DateTime.Now;
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Consulta {attendance.Id} finalizada às {attendance.EndTime}");

        }

        public bool AreWaitingAttendances()
        {
            if (Attendances.Count > 0)
                return true;
            else
                return false;
        }
    }
}
