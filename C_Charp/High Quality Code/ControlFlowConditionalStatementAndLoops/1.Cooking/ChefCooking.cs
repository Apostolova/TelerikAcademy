namespace _1.Cooking
{
    using System;
    using System.Linq;

    public class ChefCooking
    {
        public void Cook()
        {
            Bowl bowl = this.GetBowl();
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();

            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            bowl.Add(potato);           
            bowl.Add(carrot);
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.IsPeeled = true;
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.IsFresh = true;
        }
    }
}
