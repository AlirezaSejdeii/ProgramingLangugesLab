using ProgramingLangugesLab;

Menu();

static void Menu()
{
    Console.WriteLine("COMMAND:");
    Console.WriteLine("1 ====> Check Masahat");
    Console.WriteLine("2 ====> C to F");
    Console.WriteLine("3 ====> Convert numbers to abs");
    Console.WriteLine("4 ====> Check `Yaraneh` of family");
    Console.WriteLine("5 ====> Check end score of students");
    Console.WriteLine("6 ====> Check phone credit");
    Console.WriteLine("7 ====> Check Tax");
    Console.WriteLine("8 ====> Ligth speed calcluator");
    Console.WriteLine("Exit");



    switch (Console.ReadKey(true).KeyChar)
    {
        case '1':
            Calculate.CalculateMasahat();
            Clear.ClearConsole();
            Menu();
            break;
        case '2':
            Converter.ConvertCToF();
            Clear.ClearConsole();
            Menu();
            break;
        case '3':
            Converter.GetAbsOfArray();
            Clear.ClearConsole();
            Menu();
            break;
        case '4':
            Calculate.YaranehCal();
            Clear.ClearConsole();
            Menu();
            break;
        case '5':
            Calculate.StudentScore();
            Clear.ClearConsole();
            Menu();
            break;
        case '6':
            Calculate.CalcuteMobileCredit();
            Clear.ClearConsole();
            Menu();
            break;
        case '7':
            Calculate.TaxCalcute();
            Clear.ClearConsole();
            Menu();
            break;
        case '8':
            Calculate.CalcutelightSpeed();
            break;
        default:
            Clear.ClearConsole();
            Menu();
            break;
    }
}