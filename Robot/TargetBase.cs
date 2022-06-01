namespace Robot {
   public class TargetBase {

      public int Health { get; set; }

      public bool IsAlive { get; set; }

      public string Name { get; set; }

      public virtual void GetHitByLaser() {

      }

   }
}
