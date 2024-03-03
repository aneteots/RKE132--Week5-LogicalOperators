//Math >= 90 OR Biology >= 90 OR Chemistry >= 90;
//math ja chemistry OR math ja biology OR chemistry ja biology

int math, biology, chemistry;
Console.WriteLine("Write your Math result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry result:");
chemistry = Int32.Parse(Console.ReadLine());

if ((math >= 90 && chemistry >= 90) || (chemistry >= 90 && biology >= 90) || (math >= 90 && biology >= 90))
{
    Console.WriteLine("Congratulations! You have been accepted.");
}
else
{
    Console.WriteLine("Your application cannot be accepted.");
}