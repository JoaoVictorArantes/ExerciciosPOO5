namespace ExerciciosPOO5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno = new Aluno();

            Console.WriteLine("Digite os dados do aluno:");
            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno:");
            aluno.nota1 = Convert.ToDouble(Console.ReadLine());
            aluno.nota2 = Convert.ToDouble(Console.ReadLine());
            aluno.nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(aluno);
            Console.WriteLine(aluno.Situacao());

            Console.ReadKey();
        }
    }
}
