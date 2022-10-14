using System.Collections.Generic;
using api_stone.Models;

namespace api_stone.Servicos
{
    public class ClienteSingleton
    {
        private ClienteSingleton(){}
        private static ClienteSingleton clienteSingleton;

        private List<Cliente> clientes = new List<Cliente>();

        public List<Cliente> Clientes()
        {
            return clientes;
        }

        public void Adicionar(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        public static ClienteSingleton GetInstancia(){
            if(clienteSingleton == null)
                clienteSingleton = new ClienteSingleton();
            
            return clienteSingleton;
        }
    }
}
