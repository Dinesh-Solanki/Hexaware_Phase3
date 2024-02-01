using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPatternBuilder
{
    public class DesignPatternChildrenMeal
    {
        public static void Main(string[] args)
        {
            ChildrenMealBuilder builder;

            Shop1 shop = new Shop1();

            builder = new Meal1();
            shop.Construct(builder);
            builder.ChildrenMeal.Show();

            builder = new Meal2();
            shop.Construct(builder);
            builder.ChildrenMeal.Show();

            builder = new Meal3();
            shop.Construct(builder);
            builder.ChildrenMeal.Show();

            Console.ReadKey();
           
        }
    }

    class Shop1
    {
        public void Construct(ChildrenMealBuilder childrenMealBuilder)
        {
            childrenMealBuilder.BuildMainItem();
            childrenMealBuilder.BuildSideItem();
            childrenMealBuilder.BuildDrink();
            childrenMealBuilder.BuildToy();
        }
    }

    abstract class ChildrenMealBuilder
    {
        protected ChildrenMeal childrenMeal;

        public ChildrenMeal ChildrenMeal
        {
            get { return childrenMeal; }
        }

        public abstract void BuildMainItem();
        public abstract void BuildSideItem();
        public abstract void BuildDrink();
        public abstract void BuildToy();
    }

    class Meal1 : ChildrenMealBuilder
    {
        public Meal1()
        {
            childrenMeal = new ChildrenMeal("Meal 1");
        }

        public override void BuildMainItem()
        {
            childrenMeal["mainItem"] = "Hamburger";
        }

        public override void BuildSideItem()
        {
            childrenMeal["sideItem"] = "Fries";
        }

        public override void BuildDrink()
        {
            childrenMeal["drink"] = "Coke";
        }

        public override void BuildToy()
        {
            childrenMeal["toy"] = "Dinosaur";
        }
    }   


    class Meal2 : ChildrenMealBuilder
    {
        public Meal2()
        {
            childrenMeal = new ChildrenMeal("Meal 2");
        }

        public override void BuildMainItem()
        {
            childrenMeal["mainItem"] = "Cheeseburger";
        }

        public override void BuildSideItem()
        {
            childrenMeal["sideItem"] = "Onion Rings";
        }

        public override void BuildDrink()
        {
            childrenMeal["drink"] = "Sprite";
        }

        public override void BuildToy()
        {
            childrenMeal["toy"] = "Car";
        }
    }


    class Meal3 : ChildrenMealBuilder
    {
        public Meal3()
        {
            childrenMeal = new ChildrenMeal("Meal 3");
        }

        public override void BuildMainItem()
        {
            childrenMeal["mainItem"] = "Chicken";
        }

        public override void BuildSideItem()
        {
            childrenMeal["sideItem"] = "Salad";
        }

        public override void BuildDrink()
        {
            childrenMeal["drink"] = "Water";
        }

        public override void BuildToy()
        {
            childrenMeal["toy"] = "Puzzle";
        }
    }

    class ChildrenMeal
    {
        private string _childrenMealType;
        private Dictionary<string, string> _childrenMeal = new Dictionary<string, string>();

        public ChildrenMeal(string childrenMealType)
        {
            this._childrenMealType = childrenMealType;
        }

        public string this[string key]
        {
            get { return _childrenMeal[key]; }
            set { _childrenMeal[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Children Meal Type: {0}", _childrenMealType);
            Console.WriteLine(" Main Item: {0}", _childrenMeal["mainItem"]);
            Console.WriteLine(" Side Item: {0}", _childrenMeal["sideItem"]);
            Console.WriteLine(" Drink: {0}", _childrenMeal["drink"]);
            Console.WriteLine(" Toy: {0}", _childrenMeal["toy"]);
        }
    }
    
}
