using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.ChainOfResponsibility;
using Test.ChainOfResponsibility.ATMMachineApp;
using Test.DecoratorPattern;
using Test.ObserverDesignPattern.Obervable;
using Test.ObserverDesignPattern.Observer;
using Test.PracticeProblem;
using Test.StrategyPattern;
using Test.StrategyPattern.SortingApplication;

namespace Test
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            /* List<Vehicle> vehicles = new List<Vehicle>();
             vehicles.Add(new Bicycle());
             vehicles.Add(new Car());
             vehicles.Add(new MotorCycle());
             foreach (var vehicle in vehicles)
             {
                 vehicle.Drive();
             }*/

            /*
            LogProcessor processor = new InfoLogProcessor(new WarningLogProcessor(new ErrorLogProcessor(null)));
            processor.Log(LoggerType.ERROR, message: "Error");
            processor.Log(LoggerType.WARNING, message: "Warning");
            processor.Log(LoggerType.INFO, message: "Info");
            */

            /*PizzaBase paneerPizza = new PaneerPizza();
            paneerPizza = new ExtraChess(paneerPizza);
            paneerPizza = new ExtraCorn(paneerPizza);
            Console.WriteLine(paneerPizza.Cost());

            PizzaBase farmPizza = new FarmHouse();
            farmPizza = new ExtraChess(farmPizza);
            Console.WriteLine(farmPizza.Cost());*/

            /*WhetherStation subject = new WhetherStation();
            PhoneDisplay phoneDisplay = new PhoneDisplay();
            TabDisplay tabDisplay = new TabDisplay();
            subject.AddObserver(phoneDisplay);
            subject.AddObserver(tabDisplay);
            subject.RemoveObserver(tabDisplay);
            subject.AddWhether("Temperature is 45 degree celsius in Bangalore");
            subject.AddObserver(tabDisplay);
            subject.AddWhether("Temperature is 43 degree celsius in Bangalore");*/

            /*AtmProcessor processor = new HundredRsProcessor(new FiveHundredRsProcessor(new TwoThusandRsProcessor(null)));
            processor.Process(CurrencyType.Rs100, "100 Rs Credited");
            processor.Process(CurrencyType.Rs500, "500 Rs Credited");
            processor.Process(CurrencyType.Rs2000, "2000 Rs Credited");*/

            /*QuickSortStrategy quickSortStrategy = new QuickSortStrategy();
            SortingContext sorting = new SortingContext(quickSortStrategy);
            sorting.Sort("Quick Sort");

            MergeSortStrategy mergeSortStrategy = new MergeSortStrategy();
            sorting = new SortingContext(mergeSortStrategy);
            sorting.Sort("Merge Sort");*/

            MergeSortedArray mergeSortedArray = new MergeSortedArray();
            /*int[] arr1 = { 1, 2, 3, 0, 0, 0 };
            int[] arr2 = { 2, 5, 6 };

            int [] ans=mergeSortedArray.Merge(arr1, 6, arr2, 3);*/

            Console.WriteLine(mergeSortedArray.IsPalindrome("example "));

        }
    }
}
