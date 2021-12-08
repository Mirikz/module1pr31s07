using module1pr31s07;
int progcount;
int plcount;
int p;
while (true)
{
    Console.WriteLine("Демонстрация первого класса");
    Console.WriteLine("Введите фамилию");
    string secname = Console.ReadLine();
    if(int.TryParse(secname, out progcount)) { Console.WriteLine("Вы ввели число"); break; }
    Console.WriteLine("Введите число программ, написанных программистом");
    try { progcount = int.Parse(Console.ReadLine()); }
    catch { Console.WriteLine("Вы ввели не число"); break; }
    if (progcount < 0) { Console.WriteLine("Вы ввели отрицательное число"); break; }
    Console.WriteLine("Введите число языков программирования, которыми он пишет программы");
    try { plcount = int.Parse(Console.ReadLine()); }
    catch { Console.WriteLine("Вы ввели не число"); break; }
    if (plcount < 0) { Console.WriteLine("Вы ввели отрицательное число"); break; }
    Programmer programmer = new Programmer { secondname = secname, count_of_programs = progcount, count_of_langs = plcount };
    programmer.q = programmer.Q(progcount, plcount);
    programmer.Info();
    Console.WriteLine();
    Console.WriteLine("Демонстрация второго класса");
    Console.WriteLine("Введите число правильно работающих программ");
    try { p = int.Parse(Console.ReadLine()); }
    catch { Console.WriteLine("Вы ввели не число"); break; }
    if (p < 0) { Console.WriteLine("Вы ввели отрицательное число"); break; }
    ProgrammersChild ProgrammersChild = new ProgrammersChild() { P = p, count_of_programs = programmer.count_of_programs };
    Console.WriteLine("Качество объекта класса потомка: " + ProgrammersChild.qp);
    break;
}