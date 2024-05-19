      using AbstractFactoryGunFire.Unit;
      using AbstractFactoryGunFire.Unit.Archer;
      using AbstractFactoryGunFire.Unit.Knight;

      namespace AbstractFactoryGunFire

      {
      public abstract class UnitsFactory
      {
      public abstract Knight CreateKnight();
      public abstract Mage CreateMage();
      public abstract Archer CreateArcher();
      public abstract Archer DroneCreator();
      }
      }
