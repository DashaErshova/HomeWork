// Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
thirdOne(num);  

void thirdOne(int num){

    if(100 <= num && num <= 999){
            int first = num / 10;
            int second = first * 10 - num;
            int third = second * -1;
            Console.WriteLine(third);
    }    
    if(num > 999){
        while(num > 999){
        int secondNum = num / 10;
        num = secondNum;
        secondNum +=1;
    }
        int first1 = num / 10;
        int second1 = first1 * 10 - num;
        int third = second1 * -1;
        Console.WriteLine(third);
    }
    if(num < 100){
        Console.WriteLine("there is no third digit");
    }
}
