using System;
using System.Collections.Generic;
using System.Linq;

namespace UsuariosConsoleApp
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, E-mail: {Email}, Idade: {Idade}";
        }
    }

    public class Program
    {
        static List<Usuario> usuarios = new List<Usuario>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1. Cadastrar usuário");
                Console.WriteLine("2. Listar usuários");
                Console.WriteLine("3. Buscar usuário");
                Console.WriteLine("4. Sair");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarUsuario();
                        break;
                    case "2":
                        ListarUsuarios();
                        break;
                    case "3":
                        BuscarUsuario();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void CadastrarUsuario()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            usuarios.Add(new Usuario { Nome = nome, Email = email, Idade = idade });

            Console.WriteLine("Usuário cadastrado com sucesso!");
        }

        static void ListarUsuarios()
        {
            if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado.");
                return;
            }

            Console.WriteLine("Lista de usuários:");
            foreach (var usuario in usuarios)
            {
                Console.WriteLine(usuario);
            }
        }

        static void BuscarUsuario()
        {
            Console.Write("Nome do usuário: ");
            string nomeBusca = Console.ReadLine();

            Usuario usuarioEncontrado = usuarios.FirstOrDefault(u => u.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase));

            if (usuarioEncontrado == null)
            {
                Console.WriteLine("Usuário não encontrado.");
            }
            else
            {
                Console.WriteLine(usuarioEncontrado);
            }
        }
    }
}
