namespace EF_Core_Code_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            CarManagmentDbContext dbContext = new CarManagmentDbContext();
            CarCategory carCategory = new CarCategory()
            {
                Name = "Econom"
            };

            dbContext.CarCategories.Add(carCategory);
            dbContext.SaveChanges();
        }
    }
}
