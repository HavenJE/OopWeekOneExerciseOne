
// Week1 
// 1.10 Activity: Coding challenges 1
// Create a program named PaintingEstimate whose Main() method prompts a user for the length and width of a room in feet.
// Create a method that accepts the values and then computes the cost of painting the room, assuming the room is rectangular and has four full walls
// and 9-foot ceilings. The price of the job is $6.00 per square foot. Return the price to the Main() method, and display it.


class PaintingEstimate
{
   static void Main(string[] args)
    {
        int length;
        int width;

        Console.WriteLine("What is the length of the room?");
        length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the width of the room?");
        width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("For a length of ({0}) feet, and a width of ({1}) feet, painting total cost is: {2}", length, width, ComputeCost(length, width).ToString("C"));
    }

    public static double ComputeCost(int length, int width)
    {
        double totalCost = 0;
        double area = 0;
        const double cost = 6.00;
        const int height = 9;

        area = (length * height * 2) + (width * height * 2);
        totalCost = area * cost;

        return totalCost;
    }
}