using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Filas
{
	public class CallCenter
	{
		private int _counter = 0;
		public Queue<IncomingCall>? Calls { get; set; }
    

		public CallCenter()
		{
			Calls = [];
		}

		//Método para abertura de chamados
		public void Call(int clientId)
		{
			Calls!.Enqueue(
				new IncomingCall()
				{
					Id = ++_counter,
					ClientId = clientId,
					CallTime = DateTime.Now
				}
			);
		}
		public IncomingCall Answer(string consultant)
		{
            //Validação: verificar se tem atendimentos na fila
            if (Calls!.Count > 0)
            {
				IncomingCall call = Calls.Dequeue();
				call.Consultant = consultant;
				call.StartTime = DateTime.Now;
				
				return call;
            }

			return null!;
        }
		public void End(IncomingCall call)
		{
			call.EndTime = DateTime.Now;
		}
		public bool AreWaitingCalls()
		{
			if (Calls!.Count > 0)
				return true;
			else
				return false;
		}
	}
}
