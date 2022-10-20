int n1, n2, respostaS, respostaSub;

Console.WriteLine("Insira 1 numero");
n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Insira +1 numero");
n2 = Convert.ToInt32(Console.ReadLine());

respostaS = n1 + n2;
respostaSub = n1 - n2;

Console.Clear();
Console.WriteLine("\na soma dos números selecionados é "+respostaS);
Console.WriteLine("\na subtração dos números selecionados é "+respostaSub);