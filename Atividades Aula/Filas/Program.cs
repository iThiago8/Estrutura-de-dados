// Uma fila é a estrutura de dados que pode ser aplicada para representar a fila de atendimento da catina
//As pessoas que chegam entram no final da fila e as primeiras que chegaram são as primeiras a serem atendidas

//A função ENQUEUE é responsável por adicionar novos elementos à fila 
//A função DEQUEUE remove elementos da fila

//Desta forma, obedece o pricípio do FIFO
//First in, First Out

using Filas;

Random random = new();

CallCenter center = new();
center.Call(1234);
center.Call(1546);
center.Call(1865);
center.Call(1945);

while (center.AreWaitingCalls())
{
	Thread.Sleep(3000);
	IncomingCall call = center.Answer("Thigas");
    Console.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")}\n Chamada: #{call.Id}\n De: {call.ClientId}\n Atendido por: {call.Consultant}");

	Thread.Sleep(random.Next(1000, 10000));
	center.End(call);

    Console.WriteLine($"Chamado: {call.Id} encerrado às {call.EndTime}");
}

