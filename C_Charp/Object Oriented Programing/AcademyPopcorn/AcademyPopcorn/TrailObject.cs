
//task 5
namespace AcademyPopcorn
{
   public class TrailObject : GameObject
    {
      private int lifeTime;

       public TrailObject(MatrixCoords topLeft, char[,] body, int lifeTime) : base (topLeft, body)
       {   
           this.lifeTime = lifeTime;
       }

       public override void Update()
       {
           if (lifeTime > 0)
           {
               lifeTime--;
           }
           else
           {
               this.IsDestroyed = true;
           }
       }
      

    }
}
