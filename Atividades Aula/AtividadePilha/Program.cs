using AtividadePilha;

Random random = new ();

Clinic clinic = new();

void CallPatient()
{
    Thread.Sleep(6000);
    while (clinic.AreWaitingAttendances())
    {
        Thread.Sleep(1500);
        Attendance attendance = clinic.Answer("Gadeia");

        Thread.Sleep(random.Next(5500, 8000));
        clinic.EndAttendance(attendance);
    }
}

Parallel.Invoke(
    () => clinic.GenerateAttendances(),
    () => CallPatient()
);