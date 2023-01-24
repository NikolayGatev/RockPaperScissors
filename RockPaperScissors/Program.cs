Random m = new Random();
int randomChoose = m.Next(1, 4);
string computerChose = "";
switch (randomChoose)
{
	case 1:
		computerChose = "Rock";
		break;
		case 2:
		computerChose = "Paper";
		break;
		case 3:
		computerChose = "Scissors";
        break;
}
Console.Write("Chose [r]ock, [p]aper or [s]cisoors: ");
string pleyerChoose = Console.ReadLine();
Console.WriteLine($"The computer chose {computerChose}.");
if ((pleyerChoose == "r" && computerChose == "Scissors") || (pleyerChoose == "s" && computerChose == "Paper") || (pleyerChoose == "p" && computerChose == "Rock"))
{
	Console.WriteLine("You win");
}
else if ((pleyerChoose == "r" && computerChose == "Rock") || (pleyerChoose == "s" && computerChose == "Scissors") || (pleyerChoose == "p" && computerChose == "Paper"))
{
	Console.WriteLine("This game was a draw");
}
else if ((pleyerChoose == "s" && computerChose == "Rock") || (pleyerChoose == "p" && computerChose == "Scissors") || (pleyerChoose == "r" && computerChose == "Pepar"))
{
	Console.WriteLine("You lost");
}
else
{
	Console.WriteLine("Invalide Input. Try Again...");
	return;
}


