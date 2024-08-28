
char[] low = new char[26];
char[] upper = new char[26];

for (int i = 0;i < 26; i++){
    low[i] = (char)('a' + i);
    upper[i] = (char)('A' + i);
}

do{
if(args.Length == 1 && args[0].All(Char.IsLetter)){

    string key = args[0];
    string lowerKey = key.ToLower();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Введите текст, котороый хотите зашифровать.");
    Console.ForegroundColor = ConsoleColor.White;

    string? inputText = Console.ReadLine();

    if(inputText is not null){

        for(int i = 0,keyIndex = 0,n = inputText.Length;i < n;i++){

            if(Char.IsLetter(inputText[i])){

                int j = keyIndex % key.Length;
                keyIndex++;

                if(Char.IsUpper(inputText[i])){
                    int inputTextIndex = Array.IndexOf(upper,inputText[i]);
                    int keyTextIndex = Array.IndexOf(low,lowerKey[j]);

                    int newIndex = (inputTextIndex + keyTextIndex) % 26;

                    Console.Write(upper[newIndex]);
                }
                else{
                    int inputTextIndex = Array.IndexOf(low,inputText[i]);
                    int keyTextIndex = Array.IndexOf(low,lowerKey[j]);

                    int newIndex = (inputTextIndex + keyTextIndex) % 26;

                    Console.Write(low[newIndex]);
                }
            }
            else{
                Console.Write(inputText[i]);
            }
        }
    }
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nВы не ввели текст для шифрования!\n");
    Console.ForegroundColor = ConsoleColor.White;

    return 0;
}
}while(args.Length == 1 && args[0].All(Char.IsLetter));

switch(args.Length){
    case 0:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nВы не ввели аргументы командной стоки!\n");
        break;
    case > 1:
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nВы ввели больше 1 аргумента командной строки.");
        Console.WriteLine("Пожалуйста, введите только 1 аргумент командной строки.\n");
        break;
    case 1 when !args[0].All(Char.IsLetter):
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nВы ввели цифры или символы в аргументе командной строки.");
        Console.WriteLine("Допускаются только буквы алфавита.\n");
        break;
    default:
        // На случай, если есть неучтенные случаи.
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nНепредвиденная ошибка.\n");
        break;

}
Console.ForegroundColor = ConsoleColor.White;
return 1;