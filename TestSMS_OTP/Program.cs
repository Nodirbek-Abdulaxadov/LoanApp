using Messager;

Console.WriteLine("Enter your phone number:");
string number = Console.ReadLine();

Message message = new Message();
var res = await message.SendSMSAsync(number);


if (res.Success)
{
    a:
    Console.WriteLine("Enter validation code:");
    int code = int.Parse(Console.ReadLine());

    if (code == res.Code)
    {
        Console.WriteLine("Success!");
    }
    else
    {
        Console.WriteLine("Wrong code. Try again!");
        goto a;
    }
}
else
{
    Console.WriteLine(res.Message);
}