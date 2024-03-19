namespace ContaBancaria
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("Bem vindo ao Banco ETEC MCM!");

            //Instanciar a classe Conta e criar um objeto dela
            //Conta conta = new Conta();

            while (true)
            {
                try
                {

                    Console.WriteLine("Digite o número de cursos:");
                    int quantidade = Int32.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro: Digite somente números" + e.Message);
                }
            }









            //List<Curso> cursos = new List<Curso>();

            //for (int x = 0; x < quantidade; x++)
            //{
            //    Curso curso = new Curso(); // Crie um novo objeto Curso

            //    Console.WriteLine("Digite o nome do curso " + x);
            //    curso.NomeCurso = Console.ReadLine();

            //    Console.WriteLine("Digite a quantidade de alunos do curso " + x);
            //    curso.Alunos = Int32.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite o nome do professor do curso " + x);
            //    curso.NomeProfessor = Console.ReadLine();

            //    Console.WriteLine("Digite a quantidade de horas aula do curso " + x);
            //    curso.HoraAula = Int32.Parse(Console.ReadLine());

            //    cursos.Add(curso); // Adicione o curso à lista
            //}


            //Console.WriteLine("Digite o número do curso que deseja consultar");
            //int numero = Int32.Parse(Console.ReadLine());

            //switch (numero)
            //{
            //    case 0:
            //        Console.WriteLine("Nome: " + cursos[0].NomeCurso);
            //        Console.WriteLine("Alunos: " + cursos[0].Alunos);
            //        Console.WriteLine("Professor: " + cursos[0].NomeProfessor);
            //        Console.WriteLine("Horas aula: " + cursos[0].HoraAula);
            //        break;
            //    case 1:
            //        Console.WriteLine("Nome: " + cursos[1].NomeCurso);
            //        Console.WriteLine("Alunos: " + cursos[1].Alunos);
            //        Console.WriteLine("Professor: " + cursos[1].NomeProfessor);
            //        Console.WriteLine("Horas aula: " + cursos[1].HoraAula);
            //        break;
            //    case 2:
            //        Console.WriteLine("Nome: " + cursos[2].NomeCurso);
            //        Console.WriteLine("Alunos: " + cursos[2].Alunos);
            //        Console.WriteLine("Professor: " + cursos[2].NomeProfessor);
            //        Console.WriteLine("Horas aula: " + cursos[2].HoraAula);
            //        break;
            //    default:
            //        Console.WriteLine("Curso não encontrado");
            //        break;

            //}



            //Console.WriteLine("Digite o número de pessoas que deseja criar");
            //int quantidade = Int32.Parse(Console.ReadLine());


            //List<Pessoa> pessoas = new List<Pessoa>();


            //for (int x = 0; x < quantidade; x++)
            //{
            //    Pessoa pessoa = new Pessoa(); // Crie um novo objeto Pessoa

            //    Console.WriteLine("Digite o nome da pessoa " + x);
            //    pessoa.Nome = Console.ReadLine();

            //    Console.WriteLine("Digite a idade da pessoa " + x);
            //    pessoa.Idade = Int32.Parse(Console.ReadLine());

            //    Console.WriteLine("Digite o CPF da pessoa " + x);
            //    pessoa.CPF = Console.ReadLine();

            //    Console.WriteLine("Digite o sexo da pessoa " + x);
            //    pessoa.Sexo = Char.Parse(Console.ReadLine());

            //    pessoas.Add(pessoa); // Adicione a pessoa à lista
            //}


            //for (int x = 0; x < quantidade; x++)
            //{
            //    Console.WriteLine("Nome: " + pessoas[x].Nome);
            //    Console.WriteLine("Idade: " + pessoas[x].Idade);
            //    Console.WriteLine("Cpf: " + pessoas[x].CPF);
            //    Console.WriteLine("Sexo: " + pessoas[x].Sexo);
            //}





            //Console.WriteLine("Nome: " + pessoas[x].Nome);
            //Console.WriteLine("Idade: " + pessoa.Idade);
            //Console.WriteLine("Cpf: " + pessoa.CPF);
            //Console.WriteLine("Sexo: " + pessoa.Sexo);









            //Pessoa pessoa = new Pessoa(); 
            //pessoa.Nome = "João";
            //pessoa.Idade = 25;
            //pessoa.CPF = "123.456.789-00";
            //pessoa.Sexo = 'M';

            //Console.WriteLine("Nome: " + pessoa.Nome);
            //Console.WriteLine("Idade: " + pessoa.Idade);
            //Console.WriteLine("Cpf: " + pessoa.CPF);
            //Console.WriteLine("Sexo: " + pessoa.Sexo);






            //Console.WriteLine("CONSULTANDO O SALDO:");
            //conta.consulta_saldo();
            //Console.WriteLine("DEPÓSITO DE R$ 1000.35");
            //conta.depositar(1000.35);
            //Console.WriteLine("CONSULTANDO O SALDO:");
            //conta.consulta_saldo();

            //Console.WriteLine("SAQUE DE 500:");
            //conta.sacar(500);
            //Console.WriteLine("CONSULTANDO O SALDO:");
            //conta.consulta_saldo();

            //Console.WriteLine("SAQUE DE 1000:");
            //conta.sacar(1000);


            //conta.ajuste_limite(1000);
            //conta.consulta_saldo();
            //conta.sacar(2000);
            //conta.consulta_saldo();
            //int numero = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("DEPÓSITO DE R$ 1000.35");

        }
    }
}