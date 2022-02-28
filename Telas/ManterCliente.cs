using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Model;
using Biblioteca.Arquivo;
using _01_Projeto.Conversores;

namespace _01_Projeto.Telas
{
    class ManterCliente
    {
        public void CadastrarCliente()
        {
            Cliente cliente = new Cliente();

            Console.Clear();

            Console.WriteLine("CADASTRAR CLIENTE");

            Console.Write("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Data de Nascimento: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.Write("CPF (apenas números): ");
            cliente.CPF = int.Parse(Console.ReadLine());
            
            Console.Write("RG: ");
            cliente.RG = Console.ReadLine();

            Console.Write("CEP: ");
            cliente.CEP = int.Parse(Console.ReadLine());

            Console.Write("Estado: ");
            cliente.Estado = Console.ReadLine();

            Console.Write("Cidade: ");
            cliente.Cidade = Console.ReadLine();

            Console.Write("Endereco: ");
            cliente.Endereco = Console.ReadLine();

            GerenciadorArquivo.GravarArquivo("cliente", ClienteTexto.ConverterParaTexto(cliente));
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     

        }

        public void ListarClientes ()
        {
            Console.Clear();
            Console.WriteLine("LISTAGEM DE CLIENTES");

            string[] linhas = GerenciadorArquivo.LerArquivo("cliente");

            foreach (string linha in linhas)
            {
                Cliente cliente = Conversores.ClienteTexto.ConverterParaCliente(linha);
                Console.Write("Nome: " + cliente.Nome);
            }

        }
    }
}
