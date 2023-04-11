namespace Acces_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee newemployee = new Employee();
            newemployee.Name = "Prenses";
            newemployee.Salary = 300;
            newemployee.IsSuccesfull = true;


            Console.WriteLine($"Iscinin Adi: {newemployee.Name}");
            var assistant = new Assistant();
            assistant.GetFeedBack(newemployee);
        }

    }
}
